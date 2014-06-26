using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Business.Entities
{
    public class Event : BaseEntity
    {
        [Key]
        [Column("EventId")]
        public int EventId { get; set; }

        [Column("Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("ShortName")]
        [StringLength(50)]
        public string ShortName { get; set; }

        [Column("Description", TypeName = "varchar(MAX)")]
        public string Description { get; set; }

        [Column("EventStart")]
        public DateTime EventStart { get; set; }

        [Column("EventEnd")]
        public DateTime EventEnd { get; set; }

        [Column("RegistrationStart")]
        public DateTime RegistrationStart { get; set; }

        [Column("RegistrationEnd")]
        public DateTime RegistrationEnd { get; set; }
    }
}
