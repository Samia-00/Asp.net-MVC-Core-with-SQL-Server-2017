using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.ViewModel
{
    public class LaborWorkVM
    {
        public int Id { get; set; }
        [Required, StringLength(40), Display(Name = "Labor Name")]
        public string LobarName { get; set; }
        [Required, Column(TypeName = "money"), Display(Name = "Pay Rate")]
        public decimal PayRate { get; set; }
        [Required, Column(TypeName = "Date"), Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date"), Display(Name = "End Date")]
        public DateTime? FinishDate { get; set; }

        public int DaysWorked
        {
            get
            {
                return FinishDate.HasValue ? (FinishDate.Value - StartDate).Days + 1 : 0;
            }
        }
        public decimal TotalBill
        {
            get
            {
                return FinishDate.HasValue ? ((FinishDate.Value - StartDate).Days + 1)*PayRate : 0.0M;
            }
        }
    }
}
