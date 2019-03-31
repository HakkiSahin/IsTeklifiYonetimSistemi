using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
	class CityMapping : EntityTypeConfiguration<City>
	{
		public CityMapping()
		{
            HasKey(a => a.CityID);

            Property(a => a.CityName).HasMaxLength(20);
        }
        
    }
}
