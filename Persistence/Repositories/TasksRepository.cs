using LoanSystemApp.Application.Common.Interfaces;
using LoanSystemApp.Domain.Entities;
using LoanSystemApp.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using LoanSystemApp.Persistence.EntityFramework;
using System.Threading.Tasks;

namespace LoanSystemApp.Persistence.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        
        private readonly IAppDbContext _context;

        public TasksRepository(IAppDbContext context)
        {
            _context = context;
        }
       
        public async Task<int> Add(LoanSystemApp.Domain.Entities.Task entity)
        {
           _context.Tasks.Add(entity);
            await _context.SaveChangesAsync(new CancellationToken());

           return entity.ID;
        }
    }
}
