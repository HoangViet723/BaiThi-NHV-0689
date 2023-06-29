using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThi_NHV.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BaiThi_NHV.Models.NHV_Cau3> NHV_Cau3 { get; set; } = default!;

    }
