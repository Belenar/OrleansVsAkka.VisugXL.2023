namespace OrleansVsAkka.VisugXL.Orleans.Host;

public class Client
{
    private readonly IClusterClient _clusterClient;

    public Client(IClusterClient clusterClient)
    {
        _clusterClient = clusterClient;
    }

    public async Task DoSomething()
    {
        var grain = _clusterClient.GetGrain<IDeatchmatchGrain>(Guid.NewGuid());
        var result = await grain.HandleCompleteRound(new CompleteRoundContent(1));
    }
}