using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CinemaPlusDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server =DESKTOP-LUJ8MVB; database=CinamaPlus; integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Film> films { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<FilmLanguage> filmLanguages { get; set; }
        public DbSet<Hall> halls { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Seat> Seats { get; set; }
     

    }
}
