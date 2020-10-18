using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Data.Infrastrueture
{
    public class DbFactory : Disposable,IDbFactory
    {
        private FasFoodDbContext dbcontext;

        public FasFoodDbContext Init()
        {
            return dbcontext ?? (dbcontext = new FasFoodDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }
        }
    }
}
