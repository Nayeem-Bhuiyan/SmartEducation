using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Auth
{
    public class UserLogHistory : BaseEntity
    {

        [MaxLength(250)]
        [Display(Name = "User")]
        public string userName { get; set; }
        [MaxLength(250)]
        [Display(Name = "Log Out")]
        public DateTime? logOutTime { get; set; }
        [MaxLength(250)]
        [Display(Name = "IP")]
        public string ipAddress { get; set; }
        [MaxLength(250)]
        [Display(Name = "Browser")]
        public string browserName { get; set; }
        [MaxLength(250)]
        [Display(Name = "Pc Name")]
        public string pcName { get; set; }
        [NotMapped]
        [Display(Name = "Status Name")]
        public string statusName { get; set; }
        [DefaultValue(false)]
        public bool? status { get; set; }
    }
}
