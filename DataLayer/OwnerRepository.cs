using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OwnerRepository : IOwnerRepository
    {
        private DataContext context;

        public OwnerRepository() { this.context = new DataContext(); }
        public List<Owner> GetAll()
        {
            return this.context.Owners.ToList();
        }
        public Owner Get(int id)
        {
            return this.context.Owners.SingleOrDefault(e => e.Id == id);
        }
        public int Insert(Owner post)
        {
            this.context.Owners.Add(post);
            return this.context.SaveChanges();
        }
        public int Update(Owner post)
        {
            Owner postToUpdate = this.context.Owners.SingleOrDefault(e => e.Id == post.Id);
            postToUpdate.Name = post.Name;
            postToUpdate.Email = post.Email;
            postToUpdate.Address = post.Address;
            postToUpdate.Phone = post.Phone;
            postToUpdate.Phone = post.Username;
            postToUpdate.Area = post.Area;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Owner postToDelete = this.context.Owners.SingleOrDefault(e => e.Id == id);
            this.context.Owners.Remove(postToDelete);

            return this.context.SaveChanges();
        }
    }
}
