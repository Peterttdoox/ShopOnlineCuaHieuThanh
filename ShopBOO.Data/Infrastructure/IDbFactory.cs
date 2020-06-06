using System;

namespace ShopBOO.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopBOODbContext Init();
    }
}