using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.ViewModels
{
    public class BatchViewModel
    {
        public int SelectedBatch { get; set; }
        public IEnumerable<Batch> Batches { get; set; }
        public IEnumerable<Trainee>Trainees{ get; set; }
    }
}
