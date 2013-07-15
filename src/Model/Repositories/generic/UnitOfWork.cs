using Model.Repositories.Interfaces;
using ServiceStack.Logging;
using System;
using System.Data.Common;

namespace Model
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppDbContext _appDbContext;

        //private IAttributesRepository _attributesRepository;

        public ILog Logger { get; set; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbConnection GetConnection()
        {
            return _appDbContext.Database.Connection;
        }

        //public IAttributesRepository AttributesRepository
        //{
        //    get
        //    {
        //        if (this._attributesRepository == null)
        //        {
        //            this._attributesRepository = new AttributesRepository(_appDbContext);
        //        }
        //        return _attributesRepository;
        //    }
        //}

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _appDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}