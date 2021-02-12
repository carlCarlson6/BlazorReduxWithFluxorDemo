using demo2.Models.Todos;
using demo2.Redux.State.Common;
using System.Collections.Generic;

namespace demo2.Redux.State
{
    public class TodosState : RootState
    {
        public IEnumerable<TodoDto> CurrentTodos { get; }
        public TodoDto? CurrentTodo { get; }

        public TodosState(bool isLoading, string? currentErrorMessage, IEnumerable<TodoDto>? currentTodos, TodoDto? currentTodo) : base(isLoading, currentErrorMessage)
        {
            this.CurrentTodos = currentTodos;
            this.CurrentTodo = currentTodo;
        }
    }
}
