using Microsoft.EntityFrameworkCore;
using Ticketo.TicketManagement.Domain.Common;
using Ticketo.TicketManagement.Domain.Entities;

namespace Ticketo.TicketManagement.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //seed data

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category { Id = 1, Name = "Concerts" },
                new Category { Id = 2, Name = "Musicals" },
                new Category { Id = 3, Name = "Plays" },
                new Category { Id = 4, Name = "Conferences" },
                new Category { Id = 5, Name = "Comedy" }
            });

            // seed Events 

            modelBuilder.Entity<Event>().HasData(new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "John Egbert Live",
                    Price = 65,
                    Artist = "John Egbert",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
                    CategoryId = 1
                },
                new Event
                {
                    Id = 2,
                    Name = "The State of Affairs: Michael Live!",
                    Price = 85,
                    Artist = "Michael Johnson",
                    Date = DateTime.Now.AddMonths(9),
                    Description = "Michael's new stand-up show is a mix of his most clasic jokes and some new ones too. *Due to the use of explicit language, 16+ only.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/comedy.jpg",
                    CategoryId = 5
                },
                new Event
                {
                    Id = 3,
                    Name = "Clash of the DJs",
                    Price = 85,
                    Artist = "DJ 'The Mike'",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
                    CategoryId = 4
                },
                new Event
                {
                    Id = 4,
                    Name = "Spanish guitar hits with Manuel",
                    Price = 25,
                    Artist = "Manuel Santinonisi",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Get on the hype of Spanish guitar concerts with Manuel.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/guitar.jpg",
                    CategoryId = 1
                },
                new Event
                {
                    Id = 5,
                    Name = "Techorama 2021",
                    Price = 400,
                    Artist = "Many",
                    Date = DateTime.Now.AddMonths(10),
                    Description = "The best tech conference in the world",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/conference.jpg",
                    CategoryId = 4
                },
                new Event
                {
                    Id = 6,
                    Name = "John Egbert Live",
                    Price = 85,
                    Artist = "John Egbert",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
                    CategoryId = 1
                },
                new Event
                {
                    Id = 7,
                    Name = "Techorama 2022",
                    Price = 400,
                    Artist = "Many",
                    Date = DateTime.Now.AddMonths(10),
                    Description = "The best tech conference in the world",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/conference.jpg",
                    CategoryId = 4
                },
                new Event
                {
                    Id = 8,
                    Name = "Clash of the DJs",
                    Price = 85,
                    Artist = "DJ 'The Mike'",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
                    CategoryId = 4
                },
                new Event
                {
                    Id = 9,
                    Name = "Spanish guitar hits with Manuel",
                    Price = 25,
                    Artist = "Manuel Santinonisi",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Get on the hype of Spanish guitar concerts with Manuel.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/guitar.jpg",
                    CategoryId = 1
                },
                new Event
                {
                    Id = 10,
                    Name = "The State of Affairs: Michael Live!",
                    Price = 85,
                    Artist = "Michael Johnson",
                    Date = DateTime.Now.AddMonths(9),
                    Description = "Michael's new stand-up show is a mix of his most clasic jokes and some new ones too. *Due to the use of explicit language, 16+ only.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/comedy.jpg",
                    CategoryId = 5
                },
                new Event
                {
                    Id = 11,
                    Name = "John Egbert Live",
                    Price = 65,
                    Artist = "John Egbert",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
                    CategoryId = 1
                },
                new Event
                {
                    Id = 12,
                    Name = "Clash of the DJs",
                    Price = 85,
                    Artist = "DJ 'The Mike'",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
                    CategoryId = 4
                },
                new Event
                {
                    Id = 13,
                    Name = "Techorama 2023",
                    Price = 400,
                    Artist = "Many",
                    Date = DateTime.Now.AddMonths(10),
                    Description = "The best tech conference in the world",
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/conference.jpg",
                    CategoryId = 4
                },
            });



        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}