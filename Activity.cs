using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

public static class Activity
{
    [FunctionName("Activity")]
    public static string SayHello([ActivityTrigger] string name)
    {
        return $"Hello {name}!";
    }
}
