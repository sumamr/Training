using System;
using System.Collections.Generic;

namespace LocalBusinessWebApiUsingMVC.Models
{
    public partial class Roles1
    {
        public Roles1()
        {
            Users2s = new HashSet<Users2>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; } = null!;

        public virtual ICollection<Users2> Users2s { get; set; }
    }
}
