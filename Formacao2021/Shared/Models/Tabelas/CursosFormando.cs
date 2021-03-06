﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formacao2021.Shared.Models.Tabelas
{
    [Table("CursosFormandos")]
    public class CursosFormando : IBaseEntity
    {
        [ForeignKey("FormandoID")]
        public Guid FormandoID { get; set; }
        [ForeignKey("CursoID")]
        public Guid CursoID { get; set; }

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
