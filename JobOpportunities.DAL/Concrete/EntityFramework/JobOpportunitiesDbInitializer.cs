using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework
{
   public class JobOpportunitiesDbInitializer : CreateDatabaseIfNotExists<JobOpportunitiesDbContext>
	{
		protected override void Seed(JobOpportunitiesDbContext context)
		{

			base.Seed(context);

		}
		

	}
}
