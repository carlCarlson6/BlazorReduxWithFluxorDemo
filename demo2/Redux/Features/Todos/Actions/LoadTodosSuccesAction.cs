using demo2.Models.Todos;
using System.Collections.Generic;

namespace demo2.Redux.Features.Todos.Actions
{
    public class LoadTodosSuccessAction
    {
        public IEnumerable<TodoDto> Todos { get; }
        public LoadTodosSuccessAction(IEnumerable<TodoDto> todos) => Todos = todos;
    }
}
