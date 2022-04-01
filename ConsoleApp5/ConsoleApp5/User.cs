﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public UserStatus Status { get; set; }
    }

    enum UserStatus
    {
        NotnotVerified, Active, Blocked
    }
}