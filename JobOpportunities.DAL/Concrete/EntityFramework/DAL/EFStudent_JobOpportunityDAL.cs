﻿using JobOpportunities.Core.DataAccess.EntityFramework;
using JobOpportunities.DAL.Abstract;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.DAL.Concrete.EntityFramework.DAL
{
   public class EFStudent_JobOpportunityDAL :EFRepositoryBase<Student_JobOpportunity, JobOpportunitiesDbContext>,IStudent_JobOpportunityDAL
    {
    }
}
