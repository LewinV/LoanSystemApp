using LoanSystemApp.Persistence.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tasks.Commands
{
    
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly ITasksRepository _tasksRepository;
        public CreateTaskCommandHandler(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var entity = new LoanSystemApp.Domain.Entities.Task()
            {
                Title = request.Title,
                Description = request.Description

            };

            await _tasksRepository.Add(entity);
            Console.WriteLine("\n\n\n\n\n\n Code executed \n\n\n\n\n\n");

            return entity.ID;
        }
    }
    
}
