using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rico.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private RicoDbContext dbContext;
        public RicoDbContext Init()
        {
            return dbContext ?? (dbContext = new RicoDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
