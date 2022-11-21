using System;
using System.Collections.Generic;

namespace LocalBusinessWebApiUsingMVC.Models
{
    public partial class Users2
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Zipcode { get; set; }
        public string Password { get; set; } = null!;
        public int? RoleId { get; set; }

        public virtual Roles1? Role { get; set; }
    }
}
