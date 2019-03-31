using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
   class AdvisorMapping : EntityTypeConfiguration<Advisor>
    {
        public AdvisorMapping()
        {
            Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Advisor");
            });
            HasKey(a => a.ID);

            Property(a => a.Name).HasMaxLength(40);
            Property(a => a.Surname).HasMaxLength(40);
            Property(a => a.TCKN).HasMaxLength(11);
        }
    }
}
