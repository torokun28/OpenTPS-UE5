# OpenTPS-UE5

**An open-source Unreal Engine 5 third-person gameplay foundation designed for human + AI collaborative game development.**

## What is OpenTPS-UE5?

OpenTPS-UE5 is an experimental, open-source third-person gameplay foundation for Unreal Engine 5.

The project explores how a game repository can be intentionally structured so that experienced game makers, traditional developers, and AI coding agents such as OpenAI Codex can work together effectively.

The goal is not to have AI simply generate a game. The goal is to build a clean, modular, well-documented gameplay foundation that both humans and AI agents can understand, modify, test, and extend.

## Why This Project?

Modern game engines are extraordinarily capable, but their complexity can create a significant barrier between a game maker's ideas and hands-on implementation.

AI coding agents may change that relationship.

OpenTPS-UE5 is being developed as a practical experiment in whether agentic development can help designers, artists, producers, and small development teams work more directly with a modern game engine while preserving human creative direction and production judgment.

Rather than demonstrating this through isolated coding exercises, the framework will be developed and evaluated against real game-production requirements.

## Design Principles

OpenTPS-UE5 will prioritize:

- **Agent-readable architecture** — systems and dependencies should be understandable to coding agents as well as humans.
- **Modular gameplay systems** — features should be independently understandable, testable, and replaceable where practical.
- **Data-driven tuning** — important gameplay variables should be exposed for rapid iteration rather than unnecessarily hard-coded.
- **Human-directed development** — AI assists implementation and iteration; design intent and creative judgment remain human responsibilities.
- **Playable iteration** — development should favor frequent working builds and observable gameplay results.
- **Documentation as infrastructure** — architecture, conventions, decisions, and agent instructions are treated as part of the project rather than optional paperwork.
- **Safe iteration** — changes should be contained, testable, and should preserve project stability whenever possible.

## Planned Foundation

The project is expected to grow incrementally around reusable third-person gameplay systems, including:

- Character movement and locomotion
- Third-person camera systems
- Player input and interaction
- Gameplay state and abilities
- Debugging and tuning tools
- AI/gameplay interaction
- Reusable testing and validation workflows
- Agent-oriented development instructions and documentation

The exact feature set will evolve through practical development and testing.

## Future Research Directions

As the core foundation matures, OpenTPS-UE5 may also serve as a test bed for AI-native gameplay systems.

Areas of exploration may include:

- **AI-assisted NPCs** — combining conventional game AI with model-assisted behavior, decision-making, dialogue, or higher-level intent.
- **Agent-driven NPC experimentation** — evaluating where model-based agents add meaningful behavior beyond traditional behavior trees, state machines, and authored systems.
- **Hybrid AI architecture** — keeping deterministic, latency-sensitive gameplay under conventional game systems while selectively using AI for higher-level reasoning and behavior.
- **AI-assisted content and encounter iteration** — exploring whether agents can help designers build, test, and tune encounters and gameplay scenarios.
- **Automated playtesting** — agents that can play builds, identify problems, reproduce gameplay issues, and provide structured feedback.
- **Gameplay telemetry analysis** — using AI to help interpret playtest data and identify balancing or usability problems.
- **Natural-language development tools** — allowing designers and other non-engineering team members to inspect, configure, and interact with gameplay systems through higher-level instructions.

These are research directions rather than commitments to the initial framework. OpenTPS-UE5 will first establish a stable, understandable third-person gameplay foundation before adding experimental AI-native systems.

## Agentic Development Experiment

A central question behind OpenTPS-UE5 is:

> **Can an AI coding agent reliably understand an existing Unreal Engine project, implement contained gameplay changes, validate its own work, respond to human gameplay feedback, and continue iterating without requiring every creative decision to be manually translated into engineering instructions?**

The project will document both successes and failures.

Useful architecture patterns, agent instructions, development workflows, and lessons learned will remain part of the open-source repository so other developers can build on the experiment.

## Real-World Validation

OpenTPS-UE5 is being developed alongside real commercial game prototyping.

The open-source framework remains independent from proprietary game projects and intellectual property. Commercial assets, characters, game-specific content, licensed material, and proprietary source code are not part of this repository.

Where appropriate, generic systems and workflow lessons discovered through real production can be recreated or contributed independently to OpenTPS-UE5.

This separation allows the framework to be tested against practical production requirements while remaining genuinely reusable and open source.

## Current Status

**Early development / experimental**

The project is currently establishing its core architecture, development conventions, agent workflow, and initial Unreal Engine 5 gameplay foundation.

Early development will intentionally remain small and understandable while the human + AI workflow is evaluated.

## Documentation

Planned project documentation includes:

- `AGENTS.md` — instructions and development rules for coding agents
- `Docs/Architecture.md` — project architecture and system relationships
- `Docs/Roadmap.md` — development stages and priorities
- `Docs/Agent-Workflow.md` — human + AI development and validation workflow

## Contributing

OpenTPS-UE5 is at an early experimental stage. Contribution guidelines will evolve as the architecture stabilizes.

Issues, experiments, technical discussion, and contributions that improve agent-friendly game-development workflows will be welcome.

## License

OpenTPS-UE5 original project code and documentation are released under the MIT License.

Unreal Engine and any Epic-provided components remain subject to their respective licenses. Third-party content is not covered by the OpenTPS-UE5 MIT License unless explicitly stated.
