using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Client.Services;
using TodoApp.Shared;

namespace TodoApp.Client.Features
{
    public class UpdateTodoHandler : IRequestHandler<UpdateTodoRequest>
    {
        private readonly ITodosService _todos;

        public UpdateTodoHandler(ITodosService todos)
        {
            _todos = todos;
        }

        public async Task<Unit> Handle(UpdateTodoRequest request, CancellationToken cancellationToken)
        {
            var todo = new Todo(request.Text, request.Done)
            {
                Id = request.Id
            };
            await _todos.UpdateAsync(todo);
            return Unit.Value;
        }
    }
}
