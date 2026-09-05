# OpenTPS-UE5 Roadmap

## Purpose

OpenTPS-UE5 is being developed incrementally as both:

1. a reusable Unreal Engine 5 third-person gameplay foundation; and
2. a practical test bed for human + AI collaborative game development.

The roadmap intentionally begins with conventional, understandable gameplay systems before introducing more experimental agentic and AI-native capabilities.

The goal is to learn whether AI agents can participate in an ongoing production process — not simply generate isolated pieces of code.

---

## Phase 0 — Clean Foundation

**Goal:** Establish a small, stable, legally clean UE5 project that humans and coding agents can understand.

### Initial Work

- Create a clean Unreal Engine 5 C++ project.
- Establish repository and folder conventions.
- Define C++ / Blueprint responsibilities.
- Establish input and configuration conventions.
- Add basic development and debug utilities.
- Document project architecture.
- Establish agent instructions through `AGENTS.md`.
- Establish repeatable build and validation procedures.
- Keep all proprietary commercial game content outside the repository.

### Success Criteria

A new developer or coding agent should be able to inspect the repository and determine:

- what the project is;
- how it is organized;
- where major gameplay systems belong;
- how to build it;
- how to validate a change;
- what content must not be introduced.

---

## Phase 1 — Playable TPS Foundation

**Goal:** Build a compact but genuinely useful third-person gameplay framework.

### Core Systems

#### Character

- Third-person character controller
- Walking and running
- Acceleration and deceleration
- Jumping and falling
- Configurable movement parameters

#### Camera

- Third-person follow camera
- Configurable distance and field of view
- Camera collision handling
- Free-look experimentation
- Camera state transitions

#### Input

- Enhanced Input foundation
- Keyboard and mouse support
- Controller support
- Rebind-friendly input architecture

#### Interaction

- Generic interaction system
- Interactable object interface
- Context-sensitive actions
- Configurable interaction range

#### Gameplay Foundation

- Health / damage framework
- Basic gameplay state
- Reusable components where appropriate
- Designer-accessible tuning variables

#### Development Tools

- Runtime debug information
- Gameplay-state visualization
- Rapid tuning controls where useful
- Logging conventions

### Success Criteria

The repository should provide enough functionality for a developer to begin building a third-person prototype without rebuilding fundamental character, camera, input, interaction, and debugging systems from scratch.

---

## Phase 2 — Agent Development Loop

**Goal:** Move from AI-assisted code generation toward repeatable agent participation in development.

The desired loop is:

**Human Intent → Agent Inspection → Plan → Implementation → Build/Test → Human Evaluation → Revision**

### Areas of Development

- Repository-aware agent instructions
- Architecture documentation designed for machine and human readability
- Build and validation scripts
- Automated checks where practical
- Structured debug output
- Test maps / scenarios for individual gameplay systems
- Agent-readable task and validation conventions

### Research Questions

- Can an agent reliably identify the correct system to modify?
- Can it understand dependencies before editing?
- Can it make contained changes without unnecessary refactoring?
- Can it build and validate its own implementation?
- Can it recognize uncertainty rather than fabricate success?
- Can it respond effectively to subjective human gameplay feedback?
- Can it revisit its own implementation after the obvious problem has been solved?
- Can useful development context survive across multiple iterations?

### Success Criteria

An agent should be able to receive a reasonably high-level gameplay request, inspect the project, implement a contained solution, validate objective behavior where possible, and return the result for human gameplay judgment.

---

## Phase 3 — Automated Observation & Playtesting

**Goal:** Explore whether agents can participate in evaluating the game rather than only modifying its source.

### Potential Capabilities

- Automated launch and test scenarios
- Screenshot / frame observation
- Structured gameplay-state capture
- Log and error interpretation
- Automated input sequences
- Regression detection
- Reproduction of reported gameplay problems
- Basic autonomous playtesting
- Structured playtest reports

### Longer-Term Development Loop

**Human Intent**
↓  
**Agent Implements**
↓  
**Project Builds**
↓  
**Agent Observes / Plays**
↓  
**Agent Identifies Problems**
↓  
**Human Evaluates**
↓  
**Agent Iterates**

Human judgment remains authoritative for subjective areas such as:

- game feel;
- visual quality;
- pacing;
- readability;
- fun;
- creative direction.

### Research Questions

- Can an agent distinguish a functional implementation from a good gameplay result?
- What game-state information helps an agent understand what occurred?
- Can agents reproduce bugs consistently?
- Can automated observation reduce iteration time for small teams?
- Which problems require human perception and judgment?

---

## Phase 4 — AI-Native Gameplay Experiments

**Goal:** Explore selective uses of model-based AI inside gameplay after the conventional foundation is stable.

These experiments are not requirements for the initial OpenTPS framework.

### AI-Assisted NPCs

Explore hybrid NPC architecture in which model-based AI can influence:

- higher-level intent;
- contextual decisions;
- tactical reasoning;
- dialogue;
- longer-term behavior.

Traditional game systems should remain responsible where appropriate for:

- movement;
- navigation;
- aiming;
- animation;
- collision;
- immediate combat execution;
- authoritative game rules.

Conceptually:

**Model / Agent**
↓
Higher-Level Intent & Reasoning
↓
**Traditional Game AI**
↓
Behavior / Navigation / Combat Execution
↓
**UE5 Gameplay Systems**

This allows experimentation with model-assisted behavior without making latency-sensitive gameplay dependent on an external model.

### Other Research Areas

- AI-assisted encounter design
- Automated balancing experiments
- Gameplay telemetry interpretation
- Natural-language designer tools
- Dynamic NPC behavior
- AI-assisted content iteration
- Agent-generated test scenarios

### Reliability Principle

Experimental AI services should degrade gracefully.

A playable game should not become fundamentally unusable simply because an external AI service is unavailable.

---

## Phase 5 — Open Development & Community Validation

**Goal:** Determine whether the architecture and workflows remain useful beyond the original project team.

Potential work includes:

- Example projects
- Tutorials
- Contribution guidelines
- Reusable gameplay modules
- Community test cases
- Agent workflow examples
- Published successes and failures
- Comparisons of conventional and agent-assisted workflows

The project should document approaches that fail as well as those that succeed.

Negative results are useful if they help other developers understand the practical limits of agentic game development.

---

## Development Philosophy

OpenTPS-UE5 is not intended to predict exactly how AI game development will work.

It is intended to provide a place to **find out by building.**

The project will therefore favor:

- working prototypes over speculative architecture;
- measurable experiments over AI claims;
- frequent playable iteration;
- human creative judgment;
- transparent documentation;
- systems that can evolve as agent capabilities improve.

The roadmap itself should change when practical development teaches us something better.
