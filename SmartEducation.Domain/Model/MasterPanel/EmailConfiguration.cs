using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class EmailConfiguration:BaseEntity
    {
        [StringLength(250)]
        public string fromName { get; set; }
        [StringLength(250)]
        public string fromMail { get; set; }
        [StringLength(250)]
        public string ccEmail { get; set; }
        [StringLength(250)]
        public string bccEmail { get; set; }
        [StringLength(150)]
        public string smtpServer { get; set; }
        public int serverPort { get; set; }
        [StringLength(250)]
        public string hostName { get; set; }
        [StringLength(250)]
        public string userName { get; set; }
        [StringLength(250)]
        public string password { get; set; }
        [DefaultValue(false)]
        public bool isServerUseSsl { get; set; }
    }
}
