using System;

namespace LearningDDD.Domain.Model
{
    public class Habit
    {
        public int HabitId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual IEquatable<HabitActivity> Notes { get; set; }
        public DateTime CreationDate { get; set; }

    }
}