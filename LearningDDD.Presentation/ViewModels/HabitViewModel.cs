using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearningDDD.Presentation.ViewModels
{
    public class HabitViewModel
    {
        [Key]
        public int HabitId { get; set; }

        [Required(ErrorMessage = "A Descrição do Hábito é necessária.")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Ativo?")]
        public bool Active { get; set; }
        // public virtual IEquatable<HabitActivity> Notes { get; set; }
        [DisplayName("Criado em")]
        public DateTime CreationDate { get; set; }
    }
}