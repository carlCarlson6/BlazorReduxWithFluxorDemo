namespace BlazorReduxDemo.Redux.Store
{
    public class CounterState
    {
        public int Count { get; }
        public CounterState(int count) {
            this.Count = count;
        }
    }   
}