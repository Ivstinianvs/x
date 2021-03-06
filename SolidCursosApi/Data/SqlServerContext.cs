﻿using Microsoft.EntityFrameworkCore;
using SolidCursosApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidCursosApi.Data
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               optionsBuilder.UseSqlServer(@"Password=biladeiro321;Persist Security Info=True;User ID=sa;Initial Catalog=SolidCursos;Data Source=DESKTOP-TDHHBQB\SQLEXPRESS");
           
              base.OnConfiguring(optionsBuilder);
        }
    }
}
