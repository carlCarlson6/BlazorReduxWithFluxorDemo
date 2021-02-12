using demo2.Redux.Features.Todos.Actions;
using demo2.Redux.State;
using Fluxor;

namespace demo2.Redux.Features.Todos.Reducers
{
    public static class LoadTodosActionsReducer
    {
        [ReducerMethod]
        public static TodosState ReduceLoadTodosAction(TodosState state, LoadTodosAction action)
        {
            return new TodosState(true, null, null, state.CurrentTodo);
        }

        [ReducerMethod]
        public static TodosState ReduceLoadTodosSuccessAction(TodosState state, LoadTodosSuccessAction action)
        {
            return new TodosState(false, null, null, state.CurrentTodo);
        }

        [ReducerMethod]
        public static TodosState ReduceLoadTodosFailureAction(TodosState state, LoadTodosFailureAction action)
        {
            return new TodosState(false, action.ErrorMessage, null, state.CurrentTodo);
        }
    }
}
