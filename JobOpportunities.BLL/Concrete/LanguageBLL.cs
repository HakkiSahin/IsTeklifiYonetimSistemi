using JobOpportunities.BLL.Abstract;
using JobOpportunities.DAL.Abstract;
using JobOpportunities.DAL.Concrete.EntityFramework.DAL;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Concrete
{
    public class LanguageBLL : ILanguageService
    {
        EFLanguageDAL _languageDAL;

        public LanguageBLL()
        {
            _languageDAL = new EFLanguageDAL();
        }
        public bool Delete(Language language)
        {
            return _languageDAL.Remove(language)>0;
        }

        public bool DeleteByID(int languageID)
        {
            Language language = _languageDAL.Get(a => a.LanguageID == languageID);
            return _languageDAL.Remove(language) > 0;
        }

        public Language Get(int languangeID)
        {
            return _languageDAL.Get(a => a.LanguageID == languangeID);
        }

        public ICollection<Language> GetAll()
        {
            return _languageDAL.GetAll();
        }

        public bool Insert(Language language)
        {
            return _languageDAL.Add(language)>0;
        }

        public bool Update(Language language)
        {
            return _languageDAL.Update(language) > 0;
        }
    }
}
