﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.DTOs.Responses
{
    public class LoginResponse
    {
        public int? UserId {  get; set; }
        public string JwtToken {  get; set; }
    }
}
