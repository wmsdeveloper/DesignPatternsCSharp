﻿using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repository {
    public class GenericRepository<T> : IGenericRepository<T> where T : class {
        protected readonly ApplicationContext _context;
        public GenericRepository(ApplicationContext context) {
            _context = context;
        }

        public async Task AddAsync(T entity) {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities) {
            await _context.Set<T>().AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression) {
            return await Task.Run(() => _context.Set<T>().Where(expression));
        }

        public async Task<IEnumerable<T>> GetAllAsync() {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity) {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities) {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}