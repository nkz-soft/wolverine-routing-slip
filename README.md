# Wolverine.RoutingSlip

A focused .NET library for durable routing-slip style orchestration on top of Wolverine.

## Goals

- Provide a lightweight routing slip abstraction for multi-step distributed workflows.
- Keep orchestration durable and restart-safe.
- Support compensation and idempotent step execution.
- Integrate cleanly with Wolverine, EF Core, and PostgreSQL-backed persistence.
- Stay friendly to vertical-slice and DDD-oriented applications.

## Repository layout

```text
src/
  Wolverine.RoutingSlip/
  Wolverine.RoutingSlip.Abstractions/
tests/
  Wolverine.RoutingSlip.Tests/
  Wolverine.RoutingSlip.IntegrationTests/
samples/
  Wolverine.RoutingSlip.Sample.Api/
docs/
build/
```

## Planned packages

- `Wolverine.RoutingSlip.Abstractions` — contracts and public primitives.
- `Wolverine.RoutingSlip` — implementation, persistence integration, Wolverine wiring.

## First milestones

1. Define core abstractions.
2. Add execution pipeline and compensation model.
3. Add persistence for slip state and activity log.
4. Add Wolverine integration extensions.
5. Add sample API and integration tests.

## Build

```bash
dotnet restore
dotnet build -c Release
dotnet test -c Release
```
