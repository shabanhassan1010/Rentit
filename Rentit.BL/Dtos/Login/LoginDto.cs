﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentit.BL.Dtos
{
    public class LoginDto
    {
        public string UserName { get; set; }    = string.Empty; 
        public string Password { get; set; } =string.Empty; 
    }
}
