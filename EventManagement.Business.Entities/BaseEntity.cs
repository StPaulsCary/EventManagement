using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Business.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// Date entity was created
        /// </summary>
        [Column("DateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Last date Modified
        /// </summary>
        [Column("DateModified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Gets or sets whether this record has been soft deleted.
        /// </summary>
        [Column("IsRemoved")]
        public bool IsRemoved { get; set; }
    }
}
