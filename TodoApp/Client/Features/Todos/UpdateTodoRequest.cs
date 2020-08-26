using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Client.Features
{
    public class UpdateTodoRequest : IRequest
    {
        public Guid Id { get; set; }

        public string Text { get; set; }
        public bool Done { get; set; }

        public UpdateTodoRequest() { }

        public UpdateTodoRequest(Guid id, string text, bool done) 
        {
            Id = id;
            Text = text;
            Done = done;
        }
    }
}
