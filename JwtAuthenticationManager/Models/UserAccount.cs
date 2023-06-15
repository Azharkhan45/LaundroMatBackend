﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Models
{
    internal class UserAccount
    {
        public int UserId { get; set; }
        public string UserRole { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public long UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public int UserPinCode { get; set; }
    }
}
