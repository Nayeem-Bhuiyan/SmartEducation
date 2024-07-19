﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AddressCategory : BaseEntity
    {
        [StringLength(100)]
        public string name { get; set; }
    }
}
