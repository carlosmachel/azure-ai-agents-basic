# azure-ai-agents-basic

Basic Azure AI Agent Demo

## Description

This project presents a simple implementation of AI agents using Azure AI Agents resources. The goal is to demonstrate how to create, manage conversation threads, and interact with persistent agents using Azure infrastructure.

## Features

- **AI Agent Creation**: Create new agents with custom name and instructions.
- **Thread Management**: Create conversation threads associated with agents.
- **Execution and Interaction**: Send messages to agents and get responses in active threads.

## Project Structure

- `src/AzureAiAgentsBasic/Application/Service.cs`: Main class that implements the logic for creating agents, threads, and executing interactions.
- `src/AzureAiAgentsBasic/Application/Module.cs`: Defines HTTP endpoints for interacting with agents.
- `src/AzureAiAgentsBasic/Application/AzureAiSettings.cs`: Configuration class for Azure AI integration.
- `src/AzureAiAgentsBasic/Program.cs`: ASP.NET Core application initialization and service configuration.

## Endpoints

- `POST /ai-agent`: Creates a new agent.
  - Parameters: `name`, `instructions`
- `GET /ai-agent/create-thread`: Creates a new conversation thread.
- `GET /ai-agent/run`: Sends a message to an agent in a thread.
  - Parameters: `agentId`, `threadId`, `userInput`

## Requirements

- .NET 8 or higher
- Azure account and resources configured for AI agents usage
- Configuration of variables in `AzureAiSettings` (model and service uri)

## Usage Example

```bash
curl -X POST "https://your-api/ai-agent?name=MyAgent&instructions=Respond as a polite assistant"
```

```bash
curl "https://your-api/ai-agent/create-thread"
```

```bash
curl "https://your-api/ai-agent/run?agentId=<id>&threadId=<id>&userInput=Hello, agent!"
```

## License

MIT License - see the [LICENSE](LICENSE) file for more details.

---

> Project maintained by [Carlos Machel](https://github.com/carlosmachel)
