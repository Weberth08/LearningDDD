using AutoMapper;

namespace LearningDDD.Presentation.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegiterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}