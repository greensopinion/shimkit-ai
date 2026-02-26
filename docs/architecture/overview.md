# Architecture Overview

shimkit-ai is structured as a .NET monorepo with a clean separation between core library and CLI tooling.

## Projects

- `Shimkit.AI.Core` — shared abstractions, models, and configuration for AI provider integrations.
- `Shimkit.AI.Cli` — command-line interface that consumes Core to interact with AI models.

## Key design principles

- Depend on abstractions (`IModelProvider`) so concrete AI providers can be swapped.
- Use `Microsoft.Extensions.DependencyInjection` for composition.
- Use `Microsoft.Extensions.Options` for typed configuration.
- Keep the CLI thin — business logic lives in Core.
