﻿using System.ComponentModel.DataAnnotations;
using System;

namespace ContosoUniversity1.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
