using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Dominio.Entidades
{
    public class Administrador
    {
        [Key] // Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incremento
        public int Id { get; set; } = default!;

        [Required]
        [StringLength(30)]
        public string Email { get; set; } = default!;

        [Required]
        [StringLength(20)]
        public string Senha { get; set; } = default!;

        [Required]
        [StringLength(10)]
        public string Perfil { get; set; } = default!;
    }
}