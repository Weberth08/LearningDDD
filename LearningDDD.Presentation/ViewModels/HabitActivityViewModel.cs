using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearningDDD.Presentation.ViewModels
{
    public class HabitActivityViewModel
    {
        [Key]
        public int HabitActivityId { get; set; }
        public int HabitId { get; set; }

        [DisplayName("Nota")]
        public string Note { get; set; }

        [DisplayName("Realizado?")]
        public bool Completed { get; set; }
        public DateTime CreationDate { get; set; }
        //public virtual Habit Habit { get; set; }
    }
}