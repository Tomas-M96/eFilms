using eFilms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFilms.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration for the StoreFilms join table
            modelBuilder.Entity<StoreFilms>().HasKey(sf => new
            {
                sf.StoreId,
                sf.FilmId
            });

            //Define the relationships between the two tables and the join table
            modelBuilder.Entity<StoreFilms>().HasOne(f => f.Film).WithMany(sf => sf.StoreFilms).HasForeignKey(f => f.FilmId);
            modelBuilder.Entity<StoreFilms>().HasOne(f => f.Store).WithMany(sf => sf.StoreFilms).HasForeignKey(f => f.StoreId);


            //Configuration for the FilmActors join table
            //Define the keys for the table
            modelBuilder.Entity<FilmActors>().HasKey(af => new
            {
                af.ActorId,
                af.FilmId
            });

            //Define the relationships between the two tables and the join table
            modelBuilder.Entity<FilmActors>().HasOne(f => f.Film).WithMany(af => af.FilmActors).HasForeignKey(f => f.FilmId);
            modelBuilder.Entity<FilmActors>().HasOne(f => f.Actor).WithMany(af => af.FilmActors).HasForeignKey(f => f.ActorId);


            base.OnModelCreating(modelBuilder);
        }

        //Properties for the tables
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmActors> FilmActors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
