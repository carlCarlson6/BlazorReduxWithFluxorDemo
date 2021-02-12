using demo2.Redux.State.Common;

namespace demo2.Redux.Features.Todos.Actions
{
    public class LoadTodosFailureAction : FailureAction
    {
        public LoadTodosFailureAction(string errorMessage) : base(errorMessage)
        {
        }
    }
}
