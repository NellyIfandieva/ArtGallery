using GalleryDataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GalleryData
{
    public class GalleryDbContext : IdentityDbContext<GalleryUser, IdentityRole, string>
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
