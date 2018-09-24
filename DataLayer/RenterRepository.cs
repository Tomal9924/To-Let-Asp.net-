using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RenterRepository : IRenterRepository
    {
        private DataContext context;

        public RenterRepository() { this.context = new DataContext(); }

        public List<Renter> GetAll()
        {
            return this.context.Renters.ToList();
        }

        public Renter Get(int id)
        {
            return this.context.Renters.SingleOrDefault(e => e.Id == id);
        }

        public int Insert(Renter emp)
        {
            this.context.Renters.Add(emp);
            return this.context.SaveChanges();
        }

        public int Update(Renter emp)
        {
            Renter empToUpdate = this.context.Renters.SingleOrDefault(e => e.Id == emp.Id);
            empToUpdate.Name = emp.Name;
            empToUpdate.Mail = emp.Mail;
            empToUpdate.Address = emp.Address;
            empToUpdate.Phone = emp.Phone;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Renter empToDelete = this.context.Renters.SingleOrDefault(e => e.Id == id);
            this.context.Renters.Remove(empToDelete);

            return this.context.SaveChanges();
        }
    }
}
