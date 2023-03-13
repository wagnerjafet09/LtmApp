﻿using System;
using System.Runtime.CompilerServices;

namespace LtmApp.BL.Core
{
    public class ServiceResult
    {
        public ServiceResult() 
        { 
            this.Success = true;
        }
        public bool Success { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}
