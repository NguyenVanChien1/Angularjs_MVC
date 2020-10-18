using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasFood.Data.Infrastrueture
{
    public interface IDbFactory:IDisposable
    {
        FasFoodDbContext Init();
    }
}
