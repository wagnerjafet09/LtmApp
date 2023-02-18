using LtmApp.DAL.Context;
using LtmApp.DAL.Core;
using Microsoft.EntityFrameworkCore;
using System;


namespace LtmApp.DAL.DbFactory
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly LtmContext ltmContext;
        public DbFactory(LtmContext ltmContext) => this.ltmContext = ltmContext;

        private bool isDisposed;

        public DbContext GetDbContext => this.ltmContext;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing) 
        {
            if (!this.isDisposed) 
            {
                if (this.ltmContext != null) 
                {
                    this.ltmContext.Dispose();
                }
            }
            this.isDisposed = true;
        }
    }
}
