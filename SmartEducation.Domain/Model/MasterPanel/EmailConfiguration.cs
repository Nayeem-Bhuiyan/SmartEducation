using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class EmailConfiguration:BaseEntity
    {
        public string fromName { get; set; }
        public string fromMail { get; set; }
        public string ccEmail { get; set; }
        public string bccEmail { get; set; }
        public string smtpServer { get; set; }
        public int serverPort { get; set; }
        public string hostName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        [DefaultValue(false)]
        public bool isServerUseSsl { get; set; }
    }
}
