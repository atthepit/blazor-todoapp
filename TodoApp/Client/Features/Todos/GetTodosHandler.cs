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
    public class GetTodosHandler : IRequestHandler<GetTodosRequest, GetTodosResponse>
    {
        private readonly ITodosService _todos;

        public GetTodosHandler(ITodosService todos)
        {
            _todos = todos;
        }

        public async Task<GetTodosResponse> Handle(GetTodosRequest request, CancellationToken cancellationToken)
        {
            var todos = await _todos.GetAllAsync();
            return new GetTodosResponse()
            {
                Todos = todos
            };
        }
    }
}
