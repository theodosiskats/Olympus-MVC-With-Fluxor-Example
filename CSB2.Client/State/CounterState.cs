using Fluxor;

namespace CSB2.Client.State;

[FeatureState]
public record CounterState
{
    public int ClickCount { get; init; }
    public CounterState() => ClickCount = 0;
}

public record IncrementCounterAction;

public static class CounterReducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        state with { ClickCount = state.ClickCount + 1 };
}