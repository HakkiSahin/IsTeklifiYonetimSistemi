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
    public class CityBLL : ICityService
    {
        EFCityDAL _cityDAL;

        public CityBLL()
        {
            _cityDAL = new EFCityDAL();
        }
        public bool Delete(City city)
        {
            return _cityDAL.Remove(city)>0;
        }

        public bool DeleteByID(int cityID)
        {
            City city = _cityDAL.Get(a => a.CityID == cityID);
            return _cityDAL.Remove(city) > 0;
        }

        public City Get(int cityID)
        {
            return _cityDAL.Get(a => a.CityID == cityID);
        }

        public ICollection<City> GetAll()
        {
            return _cityDAL.GetAll();
        }

        public bool Insert(City city)
        {
            return _cityDAL.Add(city)>0;
        }

        public bool Update(City city)
        {
            return _cityDAL.Update(city) > 0;
        }
    }
}
