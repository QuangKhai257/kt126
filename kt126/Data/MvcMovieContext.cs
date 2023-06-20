using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kt126.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<kt126.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<kt126.Models.SinhVien> SinhVien { get; set; } = default!;
    }
}
