using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using TodoApp.Client.Services;

namespace TodoApp.Client.Features
{
    public class DeleteTodoHandler : IRequestHandler<DeleteTodoRequest>
    {
        private readonly ITodosService _todos;

        public DeleteTodoHandler(ITodosService todos)
        {
            _todos = todos;
        }

        public async Task<Unit> Handle(DeleteTodoRequest request, CancellationToken cancellationToken)
        {
            await _todos.DeleteAsync(request.Todo);
            return Unit.Value;
        }
    }
}
