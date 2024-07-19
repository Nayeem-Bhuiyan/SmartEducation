using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model
{
    public abstract class BaseAuditEntity
    {
        public int Id { get; set; }

        #region Audit_Trail_Properties
        [StringLength(120)]
        public string createdBy { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? createdDate { get; set; }
        [StringLength(120)]
        public string updatedBy { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? updatedDate { get; set; }

        [DefaultValue(false)]
        public bool? isDeleted { get; set; }
        [StringLength(120)]
        public string deletedBy { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? deletedDate { get; set; }
        #endregion
    }
}
