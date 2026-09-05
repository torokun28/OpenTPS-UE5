# AGENTS.md

## Purpose

OpenTPS-UE5 is designed to be understandable and safely modifiable by both human developers and AI coding agents.

This file defines the working rules for AI agents operating inside the repository.

The objective is not to maximize the amount of code an agent produces. The objective is to make useful, understandable, testable changes while preserving project stability and human creative control.

## Core Principles

1. **Understand before modifying.**
   Inspect the relevant architecture, code, assets, documentation, and dependencies before making changes.

2. **Preserve a working project.**
   Prefer small, contained changes that can be validated independently. Do not perform broad refactors unless they are necessary and their impact is understood.

3. **Human design intent has priority.**
   Gameplay feel, creative direction, player experience, and product decisions are human responsibilities. Do not silently reinterpret a design request because another implementation seems preferable.

4. **Suggestions are encouraged.**
   If an alternative approach may be better, explain it. Where practical, distinguish between:
   - the requested implementation;
   - an alternative recommendation;
   - the reason for recommending it.

   Do not substitute the alternative without making the distinction clear.

5. **Prefer data-driven systems.**
   Gameplay values likely to require tuning should be exposed through appropriate configuration, data assets, components, or editor-accessible variables rather than unnecessarily hard-coded.

6. **Avoid hidden coupling.**
   New systems should have clear responsibilities and dependencies. Avoid creating relationships that future developers or agents cannot easily discover.

7. **Document meaningful decisions.**
   If a change affects architecture, conventions, workflows, or important system behavior, update the relevant documentation.

8. **Do not hide uncertainty.**
   If requirements are ambiguous, dependencies are unknown, or a change cannot be reliably validated, state that clearly.

## Development Workflow

For a meaningful development task, the preferred workflow is:

### 1. Inspect

Before editing:

- Identify the relevant files and systems.
- Read applicable documentation.
- Determine dependencies.
- Identify existing conventions.
- Determine how the change can be tested.

### 2. Plan

For changes involving multiple files or systems, briefly establish:

- intended behavior;
- files/systems likely to change;
- important dependencies;
- validation method;
- significant risks or assumptions.

### 3. Implement

Prefer the smallest implementation that correctly establishes the requested behavior.

Do not add speculative architecture or unrelated features simply because they may be useful later.

### 4. Validate

Where tools and environment allow:

- compile/build affected code;
- run available automated tests;
- inspect logs and warnings;
- launch the relevant gameplay scenario;
- verify that existing behavior has not obviously regressed.

If a requested behavior involves game feel or visual judgment, provide the implementation for human evaluation rather than claiming that subjective quality has been validated automatically.

### 5. Report

Summarize:

- what changed;
- why;
- what was validated;
- what could not be validated;
- remaining questions or recommended follow-up.

## Unreal Engine Guidelines

### C++ and Blueprints

Use C++ for foundational systems where maintainability, reuse, performance, or clear architecture benefits from it.

Blueprints may be used where they provide practical advantages for:

- designer-facing configuration;
- rapid gameplay iteration;
- asset-specific behavior;
- visual scripting appropriate to the task.

Do not convert systems between C++ and Blueprint merely to satisfy a blanket preference. Choose based on the role of the system.

### Gameplay Tuning

Values affecting gameplay feel should generally be easy to tune without recompiling foundational code.

Examples include:

- movement speed;
- acceleration;
- jump behavior;
- camera parameters;
- interaction ranges;
- ability timing;
- AI tuning variables.

### Debugging

When practical, reusable gameplay systems should expose enough information to make their behavior observable during development.

Prefer useful debug visualization, logs, states, and tuning controls over opaque behavior.

## Human + Agent Collaboration

OpenTPS-UE5 treats the AI agent as a development collaborator, not the creative authority.

Agents should remain curious after solving the obvious implementation problem.

When reviewing a system, consider:

- Is there an edge case the request did not mention?
- Is existing behavior likely to conflict with the new behavior?
- Is there a simpler implementation?
- Is there a more reusable implementation without unnecessary abstraction?
- Is something difficult to test or tune?
- Is there a potential gameplay or production problem worth bringing to human attention?

Raise useful observations and alternatives.

Do not assume silence means permission to redesign unrelated systems.

## Experimental AI Systems

Future versions of OpenTPS-UE5 may include model-assisted NPC behavior, automated playtesting, AI-assisted encounter creation, telemetry analysis, and other AI-native gameplay or development systems.

When working on these systems:

- keep authoritative gameplay rules deterministic where appropriate;
- separate model-based reasoning from latency-sensitive gameplay execution;
- provide graceful behavior when external AI services are unavailable;
- avoid unnecessary dependence on a specific hosted model when a clean abstraction is practical;
- document model inputs, outputs, assumptions, and failure modes;
- preserve the ability to test conventional gameplay independently of experimental AI services.

## Repository Boundaries

This repository is an independent open-source project.

Do not introduce:

- proprietary World War Toons content;
- proprietary commercial game source code;
- copyrighted assets without redistribution rights;
- marketplace/Fab content that cannot legally be redistributed;
- credentials, API keys, tokens, passwords, or private configuration;
- private production documents or confidential partner material.

If the origin or redistribution rights of an asset or piece of code are uncertain, do not add it until a human confirms that it is appropriate for the public repository.

## Safety for Destructive Changes

Do not perform destructive operations casually.

Before deleting, replacing, renaming, or substantially restructuring important project content:

1. identify dependencies;
2. explain the reason;
3. determine whether migration is required;
4. preserve recoverability through version control;
5. validate affected systems afterward.

## Definition of Done

A task is not complete merely because code was generated.

A meaningful change should ideally be:

- understandable;
- appropriately scoped;
- buildable;
- testable;
- documented where necessary;
- observable during debugging where practical;
- consistent with the requested design intent;
- ready for human gameplay evaluation when subjective judgment is required.

## Guiding Principle

**Build for iteration, not merely implementation.**

The purpose of OpenTPS-UE5 is to explore whether experienced game makers and AI agents can maintain an ongoing development conversation through a game project itself: implement, play, evaluate, question, revise, and improve.
