using System;
using System.Threading.Tasks;
using UnitOfWorkProject.Context;
using UnitOfWorkProject.Interfaces;
using UnitOfWorkProject.Models;
using UnitOfWorkProject.Repositories;

namespace UnitOfWorkProject.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext context;

        public UnitOfWork(StoreContext context)
        {
            this.context = context;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}