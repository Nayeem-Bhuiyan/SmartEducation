using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class EmailConfiguration:BaseEntity
    {
        public string FromName { get; set; }
        public string FromMail { get; set; }
        public string CcEmail { get; set; }
        public string BccEmail { get; set; }
        public string SmtpServer { get; set; }
        public int ServerPort { get; set; }
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ServerUseSsl { get; set; }
    }
}
