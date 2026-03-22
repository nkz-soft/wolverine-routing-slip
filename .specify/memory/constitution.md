<!--
Sync Impact Report
Version change: template -> 1.0.0
Modified principles:
- Principle 1 -> I. Public Contracts First
- Principle 2 -> II. Durable, Deterministic Execution
- Principle 3 -> III. Test Discipline Is Mandatory
- Principle 4 -> IV. Compatibility and Versioning Governance
- Principle 5 -> V. Operability and Developer Experience
Added sections:
- Engineering Standards
- Development Workflow and Quality Gates
Removed sections:
- Template Section 2 placeholder
- Template Section 3 placeholder
Templates requiring updates:
- ✅ .specify/templates/plan-template.md
- ✅ .specify/templates/spec-template.md
- ✅ .specify/templates/tasks-template.md
- ⚠ pending: .specify/templates/commands/*.md (directory not present in this repository)
Follow-up TODOs:
- None
-->
# Wolverine.RoutingSlip Constitution

## Core Principles

### I. Public Contracts First
All externally consumable behavior MUST be expressed through
`Wolverine.RoutingSlip.Abstractions` before implementation detail is added in
`Wolverine.RoutingSlip`. Contract changes MUST include explicit migration intent in the
feature spec and MUST preserve consumer clarity through naming, nullability, and
documentation.

### II. Durable, Deterministic Execution
Routing-slip execution and compensation behavior MUST be deterministic for identical
inputs and persisted state. State transitions MUST be explicit and auditable, and core
execution logic MUST avoid hidden side effects that prevent replay, recovery, or
idempotent retries.

### III. Test Discipline Is Mandatory
Every change MUST include automated tests at the appropriate level, with unit tests as
the default minimum bar. Integration tests MUST be added for host wiring, persistence
boundaries, messaging interactions, or contract-to-runtime behavior. If an integration
suite is intentionally deferred, CI MUST avoid treating placeholders as passing coverage
for implemented behavior.

### IV. Compatibility and Versioning Governance
The project MUST maintain semantically versioned release behavior. Breaking public API
or behavioral contract changes MUST trigger a major version plan and include explicit
upgrade guidance. Non-breaking additions SHOULD be minor version changes; documentation
and sample updates MUST accompany user-visible capability changes.

### V. Operability and Developer Experience
Builds MUST be reproducible (`packages.lock.json` and locked restore), analyzers MUST
remain enabled, and CI MUST validate build + tests for supported target frameworks.
Tooling and workflows MUST prioritize clear failures, actionable diagnostics, and
maintainable developer feedback loops.

## Engineering Standards

- Target frameworks are `net8.0`, `net9.0`, and `net10.0` unless a constitution
  amendment changes support policy.
- Nullable reference types, implicit usings, and analyzer enforcement MUST remain enabled.
- Public packages MUST preserve SourceLink and symbol packaging configuration.
- Persistent workflow behavior (state store, middleware interactions, compensation paths)
  MUST include tests that cover success and failure transitions.

## Development Workflow and Quality Gates

- Feature work begins with a spec and plan that pass the Constitution Check.
- Pull requests MUST pass CI build and unit tests before merge.
- Coverage reporting in CI MUST be generated from executable tests (not placeholders).
- Integration test placeholders MAY exist during bootstrapping, but they MUST be clearly
  marked and tracked, and MUST NOT silently mask missing runtime validation.

## Governance

This constitution supersedes conflicting repository conventions. Amendments require a
documented pull request that includes: rationale, impacted principles/sections, template
sync status, and semantic version bump justification.

Compliance reviews occur in planning and code review:
- Planning review confirms spec/plan/tasks alignment with all principles.
- Implementation review confirms tests, compatibility notes, and CI behavior meet gates.

Versioning policy for this constitution:
- MAJOR: Incompatible governance or principle removals/redefinitions.
- MINOR: New principle/section or materially expanded guidance.
- PATCH: Clarifications and non-semantic wording improvements.

**Version**: 1.0.0 | **Ratified**: 2026-03-22 | **Last Amended**: 2026-03-22
