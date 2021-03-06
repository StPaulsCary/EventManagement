﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Business.Entities
{
    public class EventItemType
    {
        [Key]
        [Column("EventItemTypeId")]
        public int EventItemTypeId { get; set; }

        [Column("Name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
