using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Business.Entities
{
    public class Registration : BaseEntity
    {
        [Key]
        [Column("RegistrationId")]
        public int RegistrationId { get; set; }

        
    }
}
