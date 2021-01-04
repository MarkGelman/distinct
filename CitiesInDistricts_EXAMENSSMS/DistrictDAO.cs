using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesInDistricts_EXAMENSSMS
{
    class DistrictDAO : IDistrictDAO
    {
        Cities_In_DistricsEntities connDB = Proj_Config.connDB;
        public void AddDistrict(City district)
        {
            connDB.Districts.Add(district);
        }

        public void DeleteDistrict(int id)
        {
            City district = connDB.Districts.FirstOrDefault(d => d.id == id);
            connDB.Districts.Remove(district);
        }

        public void GetAllDistrict()
        {
            connDB.Districts.ToList().ForEach(d => Console.WriteLine(JsonConvert.SerializeObject(d)));
        }

        public void GetDistrictById(int id)
        {
            City district = connDB.Districts.FirstOrDefault(d => d.id == id);
            Console.WriteLine(JsonConvert.SerializeObject(district)); 
        }

        public void UpdateDistrict(int id, City c)
        {
            DeleteDistrict(id);
            AddDistrict(c);
        }
    }
}
