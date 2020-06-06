using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBOO.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopBOODbContext dbContext;
        public ShopBOODbContext Init()
        {
            return dbContext ?? (dbContext = new ShopBOODbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
