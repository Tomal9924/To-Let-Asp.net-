using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OwnerAddRepository : IOwnerAddRepository
    {

         private DataContext context;

         public OwnerAddRepository() { this.context = new DataContext(); }
    
        public List<OwnerAdd> GetAll()
             {
         	return this.context.OwnerAdds.ToList();
                }
            }
        
    
}
