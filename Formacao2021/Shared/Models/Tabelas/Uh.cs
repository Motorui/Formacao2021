using Formacao2021.Shared.Models.Marcacoes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;

namespace Formacao2021.Shared.Models.Tabelas
{
    public class Uh : IBaseEntity
    {
        [Key]
        public Guid ID { get; set; }

        private string _nome;
        [Required(ErrorMessage = "O campo Nome é obrigatório"), Display(Name = "Nome:")]
        [StringLength(25, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Nome
        {
            get => _nome;
            set => _nome = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        private string _iata;
        [Required(ErrorMessage = "O campo IATA é obrigatório"), Display(Name = "IATA:")]
        [StringLength(3, ErrorMessage = "O campo {0} deve de conter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string IATA
        {
            get => _iata;
            set => _iata = value?.ToUpper(CultureInfo.InvariantCulture);
        }

        [JsonIgnore]
        [IgnoreDataMember]
        public List<Marcacao> Marcacoes { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public List<Formando> Formando { get; set; }

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
