using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoanSystemApp.Application.Common.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Domain.Entities.Task> Tasks { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
