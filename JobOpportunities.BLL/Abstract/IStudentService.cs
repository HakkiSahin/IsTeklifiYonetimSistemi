using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
	public interface IStudentService: IServiceBase<Student>
	{
		Student GetByID(int studentID);
		List<Skill> GetAllSkillByStudent(Student student);
		List<Student_Language> GetAllByStudent(Student student); 
		List<Student> GetStudentsByPortalNo(string portalNo);
       

	}
}
