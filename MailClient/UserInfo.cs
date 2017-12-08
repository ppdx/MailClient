using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
    public class UserInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Pop3Server { get; set; }
        public int Pop3ServerPort { get; set; } // 0 for NOT SET
        public string SmtpServer { get; set; }
        public int SmtpServerPort { get; set; } // 0 for NOT SET
    }
}
