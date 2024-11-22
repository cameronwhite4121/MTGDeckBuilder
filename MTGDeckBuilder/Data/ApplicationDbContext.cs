﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTGDeckBuilder.Models;

namespace MTGDeckBuilder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GameDeck> GameDecks { get; set; }
        public DbSet<GameCard> GameCards { get; set; }
        public DbSet<DeckCard> DeckCards { get; set; }
        public DbSet<UserInventory> UserInventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
