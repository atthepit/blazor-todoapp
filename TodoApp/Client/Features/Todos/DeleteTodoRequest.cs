using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;

using TodoApp.Shared;

namespace TodoApp.Client.Features
{
    public class DeleteTodoRequest : IRequest
    {
        public Todo Todo { get; set; }

        public DeleteTodoRequest() { }

        public DeleteTodoRequest(Todo todo)
        {
            Todo = todo;
        }
    }
}
