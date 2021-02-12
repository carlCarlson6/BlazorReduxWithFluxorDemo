using System;

namespace demo2.Redux.State.Common
{
    public abstract class RootState
    {
        public bool IsLoading { get; }
        public String? CurrentErrorMessage { get; }
        public bool HassCurrentError { get => !String.IsNullOrWhiteSpace(this.CurrentErrorMessage) }

        public RootState(bool isLoading, String? currentErrorMessage) => (this.IsLoading, this.CurrentErrorMessage) = (isLoading, currentErrorMessage);
    }
}
