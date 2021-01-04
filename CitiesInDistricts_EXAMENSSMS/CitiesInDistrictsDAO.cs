using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesInDistricts_EXAMENSSMS
{
    class CitiesInDistrictsDAO : ICitiesInDistricts
    {
        Cities_In_DistricsEntities connDB = Proj_Config.connDB;
       
        public void AllCitiesMoreThen(int numberPeople)
        {
            connDB.Cities.Where(c => c.population > numberPeople).ToList().ForEach(c => Console.WriteLine($"{c.population}\n")) ;
        }

        public void InsertPopulationIntoDistricts()
        {
            long i = 1;
            
            for (; i <= connDB.Districts.Count(); i++)
            {
                City district = connDB.Districts.FirstOrDefault(d => d.id == i);  
                district.population = connDB.Cities.Where(c => c.disctrict_id == i).Sum(c => (int)c.population);
            }                                   
        }

        public void AllCities ()
        {
            var cities = from c in connDB.Cities
                         select c.name;

        }
    }
}
