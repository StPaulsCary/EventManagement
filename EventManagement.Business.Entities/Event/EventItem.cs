using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Business.Entities
{
    public class EventItem : BaseEntity
    {
        [Key]
        [Column("EventItemId")]
        public int EventItemId { get; set; }

        [Column("Name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
