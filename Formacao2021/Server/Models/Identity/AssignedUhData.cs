using System;

namespace Formacao2021.Server.Models.Identity
{
    public class AssignedUhData
    {
        public Guid UhID { get; set; }
        public string Name { get; set; }
        public bool Assigned { get; set; }
    }
}
