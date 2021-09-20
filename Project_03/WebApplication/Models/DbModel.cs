using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Batch
    {
        public Batch()
        {
            Trainees = new List<Trainee>();
        }
        public int BatchId { get; set; }
        [Required,StringLength(40),Display(Name ="Batch Code") ]
        public string BatchCode { get; set; }
        //nev
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
    public class Trainee
    {
        public int TraineeId { get; set; }
        [Required, StringLength(40), Display(Name = "Trainee Name")]
        public string TraineeName { get; set; }
        [Required, StringLength(40), Display(Name = "Trainee Contact")]
        public string TraineeContact { get; set; }
        [Required, StringLength(40), Display(Name = "Trainee Email")]
        public string TraineeEmail { get; set; }
        [Required, ForeignKey("Batch")]
        public int BatchId { get; set; }
        //nev
        public virtual Batch Batch {get;set;}
    }
    public class TraineeDbContext:DbContext
    {
       
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options): base(options){ }
        
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
    public class Seeder
    {
        public static void Seed(TraineeDbContext db)
        {
            if (!db.Batches.Any())
            {
                Batch b1 = new Batch { BatchCode = "Positron-02" };
                Batch b2 = new Batch { BatchCode = "Newtron-02" };
                Batch b3 = new Batch { BatchCode = "Omega-02" };

                b1.Trainees.Add(new Trainee
                {
                    TraineeName = "Samia",
                    TraineeContact = "0098768",
                    TraineeEmail = "samia@gmail.com"
                });
                db.Batches.AddRange(new Batch[] { b1, b2, b3 });
                db.SaveChanges();
            }
        }

    }
}
