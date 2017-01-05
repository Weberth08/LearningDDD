using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.Domain.Model
{
    public class Habit
    {
        public int HabitId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

    }
}