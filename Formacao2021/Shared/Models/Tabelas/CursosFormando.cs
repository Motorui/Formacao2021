using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formacao2021.Shared.Models.Tabelas
{
    [Table("CursosFormandos")]
    public class CursosFormando
    {
        public Guid FormandoID { get; set; }
        public Guid CursoID { get; set; }

        [ForeignKey("FormandoID")]
        public Formando Formando { get; set; }
        [ForeignKey("CursoID")]
        public Curso Curso { get; set; }
    }
}
