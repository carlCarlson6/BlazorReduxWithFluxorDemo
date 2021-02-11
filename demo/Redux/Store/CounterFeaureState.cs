using Fluxor;

namespace BlazorReduxDemo.Redux.Store
{
    public class CounterFeaureState : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState(0);
        }
    }
}
