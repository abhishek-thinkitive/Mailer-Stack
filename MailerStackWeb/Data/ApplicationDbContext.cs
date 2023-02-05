using MailerStackWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MailerStackWeb.Data
{
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
        public DbSet<RecipientDetails> recipientDetails { get; set; }

    }
}

