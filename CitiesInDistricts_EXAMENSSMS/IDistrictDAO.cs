using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesInDistricts_EXAMENSSMS
{
    interface IDistrictDAO
    {
        void GetAllDistrict();
        void AddDistrict(City t);
        void UpdateDistrict(int id, City c);
        void DeleteDistrict(int id);
        void GetDistrictById(int id);
    }

    
}
