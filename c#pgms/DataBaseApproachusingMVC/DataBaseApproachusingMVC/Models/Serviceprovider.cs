﻿using System;
using System.Collections.Generic;

namespace DataBaseApproachusingMVC.Models
{
    public partial class Serviceprovider
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
