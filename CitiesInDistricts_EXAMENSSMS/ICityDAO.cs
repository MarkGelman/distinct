using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesInDistricts_EXAMENSSMS
{
    interface ICityDAO
    {
        void GetAllCity();
        void AddCity(City t);
        void UpdateCity(int id, City c);
        void DeleteCity(int id);
        void GetByIdCity(int id);
    }
}
