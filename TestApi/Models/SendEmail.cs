﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class SendEmail
    {
        public string to { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
    }
}