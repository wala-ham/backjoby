﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Domain.Settings
{
    public class MailSettings
    {
        //public string EmailFrom { get; set; }
        //public string SmtpHost { get; set; }
        //public int SmtpPort { get; set; }
        //public string SmtpUser { get; set; }
        //public string SmtpPass { get; set; }
        //public string DisplayName { get; set; }

        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
