using System;
using Microsoft.EntityFrameworkCore;
using MovieOdataDemo.Models;

namespace MovieOdataDemo.Databases
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options)
        {
        }

        public DbSet<Movie>? Movies { get; set; }
    }
}

