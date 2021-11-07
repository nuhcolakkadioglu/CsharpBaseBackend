using Microsoft.EntityFrameworkCore;
using NuhCompnay.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuhCompnay.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private DbSet<T> _entities;


        public EfQueryableRepository(DbContext context)
        {
            _context = context;

        }

        public IQueryable<T> Table { get; }
    }
}
