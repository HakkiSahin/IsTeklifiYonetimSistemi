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
    public abstract class Person : IEntity
	{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }   
		
        //Navigation Property
       
    }
}
