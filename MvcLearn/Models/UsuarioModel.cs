using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcLearn.Models
{
    public class UsuarioModel
    {
        [DisplayName("Primeiro Nome")]
        [StringLength(50, ErrorMessage="O campo Nome  permite no máximo 50 caracteres!")]
        public string nome { get; set; }
        [Required]
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        [Required(ErrorMessage="informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Email inválido.")]
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }
    }
}