using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Shared;

namespace TodoApp.Client.Features
{
    public class CreateTodoRequest : IRequest<CreateTodoResponse>
    {
        public string Text { get; set; }
        public bool Done { get; set; }

        public CreateTodoRequest() { }

        public CreateTodoRequest(string text, bool done)
        {
            Text = text;
            Done = done;
        }
    }

    public class CreateTodoResponse
    {
        public Todo Todo { get; set; }

        public CreateTodoResponse() { }

        public CreateTodoResponse(Todo todo)
        {
            Todo = todo;
        }
    }
}
