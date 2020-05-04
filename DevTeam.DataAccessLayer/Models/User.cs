﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevTeam.DataAccessLayer.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
