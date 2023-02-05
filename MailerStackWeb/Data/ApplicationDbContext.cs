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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<AddedRecipients> AddedRecipients { get; set; }
        public DbSet<AddRecipientRequest> AddRecipientRequest { get; set; }

        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<CampaignExportRequest> CampaignExportRequest { get; set; }
        public DbSet<CampaignExport> CampaignExport { get; set; }
        public DbSet<Click> Click { get; set; }
        public DbSet<CreatedLeads> CreatedLeads { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Error> Error { get; set; }

        public DbSet<Lead> Lead { get; set; }
        public DbSet<LeadStatus> LeadStatus { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Open> Open { get; set; }
        public DbSet<Recipient> Recipient { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Sender> Sender { get; set; }
        public DbSet<SentMessage> SentMessage { get; set; }
        public DbSet<Team> Team { get; set; }

       

    }
}

