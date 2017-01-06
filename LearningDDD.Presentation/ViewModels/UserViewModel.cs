using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearningDDD.Presentation.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "Digite um nome para seu usuário.")]
        public string UserAlias { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Digite seu primeiro nome.")]
        public string FirstName { get; set; }

        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Digite seu Sobrenome.")]
        public string LastName { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Digite seu E-mail.")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido.")]
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }
    }
}