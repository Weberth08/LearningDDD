using System;

namespace LearningDDD.Domain.Entities
{
    public class HabitActivity
    {
        public int HabitActivityId { get; set; }
        public int HabitId { get; set; }
        public string Note { get; set; }
        public bool Completed { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Habit Habit { get; set; }
    }
}
