using Orleans.Runtime;
using System.Text.Json.Serialization;

namespace OrleansVsAkka.VisugXL.Orleans.Host;


public interface IMyPersistedGrain : IGrainWithGuidKey
{

}



public class MyState
{
    public string? Content { get; set; }
}



public class MyPersistedGrain
{
    private readonly IPersistentState<MyState> _state;

    public MyPersistedGrain([PersistentState("myState")] IPersistentState<MyState> state)
    {
        _state = state;
    }

    public async Task DoSomething()
    {
        await _state.WriteStateAsync();
        await _state.ClearStateAsync();
        await _state.ReadStateAsync();
    }
}