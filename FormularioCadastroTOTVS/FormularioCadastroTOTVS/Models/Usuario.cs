using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormularioCadastroTOTVS.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string Email { get; set; }      
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        public string Senha { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        [Compare("Senha", ErrorMessage = "As senhas estão diferentes.")]
        public string SenhaConfirmacao { get; set; }
    }
}