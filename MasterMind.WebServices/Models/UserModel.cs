﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterMind.WebServices.Models
{
    public class UserModel
    {
        public string Username { get; set; }

        public string AuthCode { get; set; }

        public int Id { get; set; }
    }
}