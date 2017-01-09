[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LearningDDD.Presentation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LearningDDD.Presentation.App_Start.NinjectWebCommon), "Stop")]

namespace LearningDDD.Presentation.App_Start
{
    using Domain.Interfaces.Repository;
    using Domain.Interfaces.Services;
    using Domain.Service;
    using Infrastructure.Data.Repository;
    using LearningDDD.Application;
    using LearningDDD.Application.Interfaces;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //Application Layer
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IHabitAppService>().To<HabitAppService>();
            kernel.Bind<IHabitActivityAppService>().To<HabitActivityAppService>();
            kernel.Bind<IUserAppService>().To<UserAppService>();

            //Service Layer
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IHabitService>().To<HabitService>();
            kernel.Bind<IHabitActivityService>().To<HabitActivityService>();
            kernel.Bind<IUserService>().To<UserService>();

            //Repository
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IHabitRepository>().To<HabitRepository>();
            kernel.Bind<IHabitActivityRepository>().To<HabitActivityRepository>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
