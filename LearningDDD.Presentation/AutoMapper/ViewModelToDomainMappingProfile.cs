using AutoMapper;
using LearningDDD.Domain.Entities;
using LearningDDD.Presentation.ViewModels;

namespace LearningDDD.Presentation.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<HabitViewModel, Habit>();
            CreateMap<HabitActivityViewModel, HabitActivity>();
            CreateMap<UserViewModel, User>();
        }
    }
}