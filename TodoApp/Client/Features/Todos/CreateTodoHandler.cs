using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using TodoApp.Client.Services;
using TodoApp.Shared;

namespace TodoApp.Client.Features
{
    public class CreateTodoHandler : IRequestHandler<CreateTodoRequest, CreateTodoResponse>
    {
        private readonly ITodosService _todos;

        public CreateTodoHandler(ITodosService todos)
        {
            _todos = todos;
        }

        public async Task<CreateTodoResponse> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
        {
            var todo = new Todo(request.Text, request.Done);
            await _todos.AddAsync(todo);
            return new CreateTodoResponse(todo);
        }
    }
}
