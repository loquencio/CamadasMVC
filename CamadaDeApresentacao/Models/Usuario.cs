using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Models
{
    public class Usuario
    {
        [HiddenInput(DisplayValue = false)]
        public int UsuarioID { get; set; }
        
        [Display(Name = "Nome do Usuário")]
        public string Nome { get; set; }

        //[RegularExpression(@"^.+@.+\..+$", ErrorMessage = "E-mail inválido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Cadastro { get; set; }
    }
}