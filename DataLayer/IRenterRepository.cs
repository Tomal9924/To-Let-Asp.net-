using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRenterRepository
    {
        List<Renter> GetAll();
        Renter Get(int id);
        int Insert(Renter emp);
        int Update(Renter emp);
        int Delete(int id);
    }
}
