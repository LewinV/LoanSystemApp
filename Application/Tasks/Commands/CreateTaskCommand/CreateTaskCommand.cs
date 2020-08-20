using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Tasks.Commands
{

    public class CreateTaskCommand : IRequest<int>
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
    }
}
