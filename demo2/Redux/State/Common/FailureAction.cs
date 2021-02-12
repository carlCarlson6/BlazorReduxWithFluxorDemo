using System;

namespace demo2.Redux.State.Common
{
    public abstract class FailureAction
    {
        protected FailureAction(string errorMessage) =>
            ErrorMessage = errorMessage;

        public String ErrorMessage { get; }
    }
}
