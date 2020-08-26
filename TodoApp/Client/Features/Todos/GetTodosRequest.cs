using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MediatR;

using TodoApp.Shared;

namespace TodoApp.Client.Features
{
    public class GetTodosRequest : IRequest<GetTodosResponse>
    {
        public GetTodosRequest()
        {

        }
    }

    public class GetTodosResponse
    {
        public IEnumerable<Todo> Todos { get; set; }
    }
}
