namespace PingYourPackage.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Role : IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<UserInRole> UserInRoles { get; set; }

        public Role()
        {
            this.UserInRoles = new HashSet<UserInRole>();
        }
    }
}
