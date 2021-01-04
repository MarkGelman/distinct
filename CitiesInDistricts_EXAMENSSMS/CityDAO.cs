using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesInDistricts_EXAMENSSMS
{
    class CityDAO : ICityDAO
    {
        Cities_In_DistricsEntities connDB = Proj_Config.connDB;
        public void AddCity(City district)
        {
            connDB.Cities.Add(district);
        }

        public void DeleteCity(int id)
        {
            City district = connDB.Cities.FirstOrDefault(d => d.id == id);
            connDB.Cities.Remove(district);
        }

        public void GetAllCity()
        {
            connDB.Cities.ToList().ForEach(d => Console.WriteLine(JsonConvert.SerializeObject(d)));
        }

        public void GetByIdCity(int id)
        {
            City district = connDB.Cities.FirstOrDefault(d => d.id == id);
            Console.WriteLine(JsonConvert.SerializeObject(district));
        }

        public void UpdateCity(int id, City c)
        {
            DeleteCity(id);
            AddCity(c);
        }
    }
   
}
