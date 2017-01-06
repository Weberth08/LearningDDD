using AutoMapper;
using LearningDDD.Domain.Entities;
using LearningDDD.Presentation.ViewModels;

namespace LearningDDD.Presentation.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Habit, HabitViewModel>();
            CreateMap<HabitActivity, HabitActivityViewModel>();
            CreateMap<User, UserViewModel>();
        }
    }
}