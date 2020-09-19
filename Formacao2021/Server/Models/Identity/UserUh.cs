using Formacao2021.Shared.Models.Tabelas;
using System;
using System.ComponentModel.DataAnnotations;

namespace Formacao2021.Server.Models.Identity
{
    public class UserUh
    {
        [Key]
        public Guid UserUhID { get; set; }
        public Guid UhID { get; set; }
        public Uh Uh { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
