using System;
using System.Collections.Generic;
using System.Text;
using JojoMarket.Interfaces.DataBaseInterfaces;
using Microsoft.EntityFrameworkCore;


namespace JojoMarket.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
