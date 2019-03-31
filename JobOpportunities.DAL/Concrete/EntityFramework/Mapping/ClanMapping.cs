using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.Mapping
{
     class ClanMapping : EntityTypeConfiguration<Clan>
    {
        public ClanMapping()
        {
            HasKey(a => a.ClanID);

            //student tablosuna foreingkey
            HasMany(a => a.Students)
                .WithRequired(a => a.Clan)
                .HasForeignKey(a => a.ClanID);

			Property(a => a.PortalNo).HasMaxLength(6);
            Property(a => a.Term).HasMaxLength(40);
            Property(a => a.GroupClass).HasMaxLength(20);
        }
    }
}
