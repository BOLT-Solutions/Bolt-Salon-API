﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
    public class AdminCreationModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
