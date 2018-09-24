using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IOwnerRepository
    {
        List<Owner> GetAll();
        Owner Get(int id);
        int Insert(Owner post);
        int Update(Owner post);
        int Delete(int id);
    }
}

