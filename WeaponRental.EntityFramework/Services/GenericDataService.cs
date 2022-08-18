﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeaponRental.Domain.Models;
using WeaponRental.Domain.Services;

namespace WeaponRental.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly WeaponRentalDbContextFactory _contextFactory;

        public GenericDataService(WeaponRentalDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (WeaponRentalDbContext context = _contextFactory.CreateDbContext())
                {
                    EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                    await context.SaveChangesAsync();

                    return createdResult.Entity;
                }
        }

        public async Task<bool> Delete(int id)
        {
            using (WeaponRentalDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (WeaponRentalDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);

                return entity;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (WeaponRentalDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
