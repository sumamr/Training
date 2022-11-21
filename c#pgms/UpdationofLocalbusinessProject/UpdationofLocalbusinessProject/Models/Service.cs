﻿using System;
using System.Collections.Generic;

namespace UpdationofLocalbusinessProject.Models
{
    public partial class Service
    {
        public Service()
        {
            Servicebookings = new HashSet<Servicebooking>();
            Serviceproviders = new HashSet<Serviceprovider>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<Servicebooking> Servicebookings { get; set; }
        public virtual ICollection<Serviceprovider> Serviceproviders { get; set; }
    }
}
