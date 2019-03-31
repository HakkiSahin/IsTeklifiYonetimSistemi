using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Student_JobOpportunity : IEntity
	{
        [Key]
        [Column(Order = 0)]

        public Guid JobOpportunityID { get; set; }
        [Key]
        [Column(Order = 1)]

        public int StudentID { get; set; }
        public bool? IsApply { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public virtual Student Student { get; set; }
        public virtual JobOpportunity JobOpportunity { get; set; }
       
        
    }
}
