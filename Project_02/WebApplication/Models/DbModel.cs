using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class LaborWork
    {
        public int Id { get; set; }
        [Required,StringLength(40),Display(Name ="Labor Name")]
        public string LobarName { get; set; }
        [Required, Column(TypeName ="money"), Display(Name = "Pay Rate")]
        public decimal PayRate { get; set; }
        [Required, Column(TypeName = "Date"), Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date"), Display(Name = "End Date")]
        public DateTime? FinishDate { get; set; }
    }

    public class LaborDbContext : DbContext
    {
        public LaborDbContext(DbContextOptions<LaborDbContext> options) : base(options) { }

        public DbSet<LaborWork> LaborWorks { get; set; }
    }
    public class DbInitializer
    {
        public static void Seed(LaborDbContext context)
        {
            if(!context.LaborWorks.Any())
            {
                context.LaborWorks.Add(new LaborWork { LobarName = "Worker 1", PayRate = 740.00M, StartDate = new DateTime(2019, 6, 7), FinishDate = new DateTime(2019, 6, 7).AddDays(3) });
                context.LaborWorks.Add(new LaborWork { LobarName = "Worker 2", PayRate = 940.00M, StartDate = new DateTime(2019, 6, 7), FinishDate = new DateTime(2019, 6, 7).AddDays(4) });
                context.SaveChanges();
            }
        }
    }
}
