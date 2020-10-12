using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formacao2021.Shared.Models.Marcacoes
{
    [Table("Inscricoes")]
    public class Inscricao : IBaseEntity
    {
        [Key, ForeignKey("Formando"), Display(Name = "Formando")]
        public Guid FormandoID { get; set; }
        [Key, ForeignKey("Marcacao"), Display(Name = "Marcação")]
        public Guid MarcacaoID { get; set; }
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        #region BaseEntity
        [Display(Name = "Registo criado em:", ShortName = "Criado em:")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Registo criado por:", ShortName = "Criado por:")]
        public string CreatedBy { get; set; }
        [Display(Name = "Registo atualizado em:", ShortName = "Atualizado em:")]
        public DateTime? LastUpdatedAt { get; set; }
        [Display(Name = "Registo atualizado por:", ShortName = "Atualizado por:")]
        public string LastUpdatedBy { get; set; }
        #endregion
    }
}
