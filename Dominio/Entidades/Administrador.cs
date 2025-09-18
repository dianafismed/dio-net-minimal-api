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
        [key] // Anotação para chave primária
        [DataBaseGenerated(DataBaseGeneratedOption.Iden)] // Anotação para auto incremento
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}