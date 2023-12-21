using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {        

        public DbSet<About> Abouts { get; set; }
        public DbSet<BadHabbit> BadHabbits { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<DayTime> DayTimes { get; set; }
        public DbSet<Digestion> Digestions { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Sleep> Sleeps { get; set; }
        public DbSet<Stress> Stresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDay> UserDays { get; set; }
        public DbSet<UserDayTime> UserDayTimes { get; set; }
        public DbSet<UserDayTimeDigestion> UserDayTimeDigestions { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<WaterAmount> WaterAmounts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
