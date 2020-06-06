using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBOO.Data.Infrastructure
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ShopBOODbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public ShopBOODbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void commit()
        {
            DbContext.SaveChanges();
        }
    }
}
