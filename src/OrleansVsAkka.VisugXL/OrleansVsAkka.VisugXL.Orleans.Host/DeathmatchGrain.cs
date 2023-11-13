namespace OrleansVsAkka.VisugXL.Orleans.Host;


[GenerateSerializer]
public record CompleteRoundContent(int Number);

[GenerateSerializer]
public record RoundCompletedContent(int Number);




public interface IDeatchmatchGrain : IGrainWithGuidKey
{
    Task<RoundCompletedContent> HandleCompleteRound(CompleteRoundContent content);
}




public class DeatchmatchGrain : Grain, IDeatchmatchGrain
{
    public async Task<RoundCompletedContent> HandleCompleteRound(CompleteRoundContent content)
    {
        // Write your code here...

        await Task.Delay(Random.Shared.Next(1000));

        return new RoundCompletedContent(content.Number);
    }
}