using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O Nome deve ser Preenchido")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "A Observação deve ter entre 5 e 50 caracteres")]
        public string Observacao { get; set; }

        [Range(18, 50, ErrorMessage="A idade da pessoa deve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage="Informe uma idade")]
        public string Email { get; set; }

        [RegularExpression(@"[a-z]{5,25}", ErrorMessage="O Login deve conter somente letras, e ter de 5 a 25 caracteres")]
        [Required(ErrorMessage= "O Login deve ser Preenchido")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Este nome de login já existe")]
        public string Login { get; set; }


        [Required(ErrorMessage ="A senha deve ser Informada")]
        public string Senha { get; set; }

        //[Compare("Senha", ErrorMessage = "As senhas não conferem")] 
        public string ConfirmarSenha { get; set; }
    }
}