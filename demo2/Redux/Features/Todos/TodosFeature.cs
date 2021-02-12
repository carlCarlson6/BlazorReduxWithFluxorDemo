using demo2.Models.Todos;
using demo2.Redux.State;
using Fluxor;
using System;
using System.Collections.Generic;

namespace demo2.Redux.Features.Todos
{
    public class TodosFeature : Feature<TodosState>
    {
        public override string GetName() => nameof(TodosState);
        protected override TodosState GetInitialState()
        {
            bool isLoading = false;
            String currentErrorMessage = null;
            IEnumerable<TodoDto> currentTodos = null;
            TodoDto currentTodo = null;
            return new TodosState(isLoading, currentErrorMessage, currentTodos, currentTodo);
        }
    }
}
