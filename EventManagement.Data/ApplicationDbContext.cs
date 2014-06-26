using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using EventManagement.Business.Entities;

namespace EventManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        #region Entities

        //Events
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        //EventItems
        public DbSet<EventItem> EventItems { get; set; }
        public DbSet<EventItemType> EventItemTypes { get; set; }

        //Registration
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RegistrationEventItem> RegistrationEventItems { get; set; }

        #endregion
        
    }
}
