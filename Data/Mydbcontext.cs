// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// public class Mydbcontext : DbContext
// {
//         public Mydbcontext(DbContextOptions<Mydbcontext> options)
//             : base(options)
//         {
//         }

//     public DbSet<Boeking> Boekingen { get; set; } = default!;

//     public DbSet<Donatie> Donaties { get; set; } = default!;
// }