using BlazorReduxDemo.Redux.Action;
using BlazorReduxDemo.Redux.Store;
using Fluxor;

namespace BlazorReduxDemo.Redux.Reducer
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
        {
            // en ts / js es equivalente a => { ... state, Count: state.Count }
            int newCount = state.Count + 1;
            return new CounterState(newCount);
        }
    }
}
