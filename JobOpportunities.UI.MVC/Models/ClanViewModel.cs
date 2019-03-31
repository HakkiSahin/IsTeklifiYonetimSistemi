using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
	public class ClanViewModel
	{
		public int ClanID { get; set; }
		public int ContractID { get; set; }
		public int DepartmentID { get; set; }
		public string PortalNo { get; set; }
		public string Term { get; set; }
		public string GroupClass { get; set; }
		public int? TeacherID { get; set; }
	}
}