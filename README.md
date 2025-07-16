# azure-ai-agents-basic

Demonstração básica do Azure AI Agent

## Descrição

Este projeto apresenta uma implementação simples de agentes de IA utilizando os recursos do Azure AI Agents. O objetivo é demonstrar como criar, gerenciar threads de conversação e interagir com agentes persistentes utilizando a infraestrutura do Azure.

## Funcionalidades

- **Criação de agentes de IA**: Permite criar novos agentes com nome e instruções customizadas.
- **Gerenciamento de threads**: Criação de threads de conversação associadas a agentes.
- **Execução e interação**: Envio de mensagens para agentes e obtenção de respostas em threads ativas.

## Estrutura do Projeto

- `src/AzureAiAgentsBasic/Application/Service.cs`: Classe principal que implementa a lógica de criação de agentes, threads e execução de interações.
- `src/AzureAiAgentsBasic/Application/Module.cs`: Define os endpoints HTTP para interação com os agentes.
- `src/AzureAiAgentsBasic/Application/AzureAiSettings.cs`: Classe de configuração para integração com o Azure AI.
- `src/AzureAiAgentsBasic/Program.cs`: Inicialização da aplicação ASP.NET Core e configuração dos serviços.

## Endpoints

- `POST /ai-agent`: Cria um novo agente.
  - Parâmetros: `name`, `instructions`
- `GET /ai-agent/create-thread`: Cria uma nova thread de conversação.
- `GET /ai-agent/run`: Envia uma mensagem para um agente em uma thread.
  - Parâmetros: `agentId`, `threadId`, `userInput`

## Requisitos

- .NET 8 ou superior
- Conta e recursos do Azure configurados para uso de agentes de IA
- Configuração das variáveis em `AzureAiSettings` (model e uri do serviço)

## Exemplo de Uso

```bash
curl -X POST "https://sua-api/ai-agent?name=MeuAgente&instructions=Responda como um assistente educado"
```

```bash
curl "https://sua-api/ai-agent/create-thread"
```

```bash
curl "https://sua-api/ai-agent/run?agentId=<id>&threadId=<id>&userInput=Olá, agente!"
```

## Licença

MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

> Projeto mantido por [Carlos Machel](https://github.com/carlosmachel)
