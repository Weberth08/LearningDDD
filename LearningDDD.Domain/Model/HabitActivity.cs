using System;

namespace LearningDDD.Domain.Model
{
    public class HabitActivity
    {
        public int HabitActivityId { get; set; }
        public int HabitId { get; set; }
        public string Note { get; set; }
        public bool Completed { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
