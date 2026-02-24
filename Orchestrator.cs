using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

public static class Orchestrator
{
    [FunctionName("Orchestrator")]
    public static async Task<List<string>> RunOrchestrator(
        [OrchestrationTrigger] IDurableOrchestrationContext context)
    {
        var outputs = new List<string>();

        outputs.Add(await context.CallActivityAsync<string>("Activity", "Hello"));
        outputs.Add(await context.CallActivityAsync<string>("Activity", "Durable"));
        outputs.Add(await context.CallActivityAsync<string>("Activity", "Functions"));

        return outputs;
    }
}
