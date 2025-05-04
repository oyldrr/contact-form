using contact_form.Models;
using Microsoft.EntityFrameworkCore;

namespace contact_form.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
