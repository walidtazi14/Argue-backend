﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string  Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LastActive { get; set; }
        public string PolticalStanding { get; set; }
        public string Introduction { get; set; }
        public string Country { get; set; }
        public Photo picture { get; set; }
    }
}
