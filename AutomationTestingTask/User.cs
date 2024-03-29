﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
        public string? Company { get; set; }
        public string? Professional_Title{ get; set; }
        public string? TimeZone { get; set; }
        public bool RememberMe { get; set; }

    }
}
