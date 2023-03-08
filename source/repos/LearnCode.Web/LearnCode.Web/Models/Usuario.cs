using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LearnCode.Web.Models
{
    //Estamos estudando design pattern POCO
    [Table("Usuarios")]   //Pluralização - DataAnottations 
    public class Usuario
    {
        public int Id { get; set; } // Propriedade automatica 
       
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string Senha { get; set; }

    }
}