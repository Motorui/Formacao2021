using System;
using System.ComponentModel.DataAnnotations;

namespace Formacao2021.Shared.Models
{
    public interface IBaseEntity
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        DateTime? CreatedAt { get; set; }
        string CreatedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        DateTime? LastUpdatedAt { get; set; }
        string LastUpdatedBy { get; set; }
    }
}
