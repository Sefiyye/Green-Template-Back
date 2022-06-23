using Green_Template_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Green_Template_Back.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
