using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Formacao2021.Shared.Models.Tabelas
{
    [Table("Formandos")]
    public class Formando : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        private string _nome;
        [Required, Display(Name = "Nome")]
        public string Nome
        {
            get => _nome;
            set => _nome = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        [Required, Display(Name = "Número", ShortName = "Núm.")]
        public int Numero { get; set; }

        #region Relações
        [Required, Display(Name = "Unidade de handling", ShortName ="UH")]
        public Guid UhID { get; set; }
        public Uh Uh { get; set; }

        [Required, Display(Name = "Departamento")]
        public Guid DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
        #endregion

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
