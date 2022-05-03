using WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Filme
    {
        public int Id{get;internal set;}
        [Required(ErrorMessage ="o Campo é obrigatorio")]
        public string? Titulo{get; set;}
        [Required]
        public string? Diretor { get; set; }
        [StringLength(30, ErrorMessage = "o genero não pode passar de 30 caractere")]
        public string? Genero { get; set; }
        [Range(1, 600, ErrorMessage = "tempo entre 1 á 600 minutos")]
        public int Duracao { get; set; }

    }
}