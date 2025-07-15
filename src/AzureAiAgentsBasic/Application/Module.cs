using Microsoft.AspNetCore.Mvc;

namespace AzureAiAgentsBasic.Application;

public static class Module
{
    public static void Register(this IEndpointRouteBuilder app)
    {
        app.MapPost("/ai-agent", async (
                [FromServices] Service service,
                [FromQuery] string name, [FromQuery] string instructions) =>
            {
                var agentId = await service.CreateAgentAsync(name, instructions);
                return Results.Ok(agentId);
            })
            .WithTags("Ai Agents");
        
        app.MapGet("/code-interpreter/create-thread", async (
                [FromServices] Service service) =>
            {
                var agentId = await service.CreateThreadAsync();
                return Results.Ok(agentId);
            })
            .WithTags("Ai Agents");
        
        app.MapGet("/code-interpreter/run", async (
                [FromServices] Service service,
                [FromQuery] string agentId,
                [FromQuery] string threadId,
                [FromQuery] string userInput) =>
            {
                var result = await service.RunAsync(agentId, threadId, userInput);
                return Results.Ok(result);
            })
            .WithTags("CodeInterpreterTool");
    }
}