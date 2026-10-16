# GitHub Copilot Instructions for No Fog Mod

## Mod Overview and Purpose

The **No Fog** mod for RimWorld is designed to enhance gameplay by automatically removing fog from all maps when they are loaded. This mod is catered to players who prefer complete visibility of their map without any obstructions or hidden areas. Inspired by a request from Renix, this mod ensures that players can see every detail of their environment without the need to explore fogged areas.

## Key Features and Systems

- **Automatic Map Defogging**: As soon as a map is loaded, it is entirely defogged, allowing for seamless visibility across the entire map, aligning with the preference of players who dislike hidden map areas.
- **Simple Integration**: The mod integrates seamlessly with existing RimWorld mechanics and does not require any additional steps from the player to activate the defogging.
- **Harmony Patching**: Utilizes the Harmony library for method patching to achieve the defogging effect during the map loading process.

## Coding Patterns and Conventions

- **Namespace and Class Naming**: The main mod functionality is encapsulated within classes named after the actions they perform (e.g., `NoFog` for the mod logic and `Map_MapPostTick` for the Harmony patch).
- **Method Naming**: Methods are named descriptively to indicate their purpose, such as the `Postfix` method within `Map_MapPostTick` which applies the Harmony patch.
- **C# Code Structure**: The mod comprises two primary C# files:
  1. `NoFog.cs` - Handles the core mod logic and initialization.
  2. `Map_MapPostTick.cs` - Implements Harmony patching logic to interface with the game's map updates.

## XML Integration

- Though this mod does not currently utilize XML files directly, modding in RimWorld often involves XML definitions to specify data-driven aspects of the mod.
- Future expansions could include XML for additional configurable settings or options, such as enabling or disabling defogging for specific map types or conditions.

## Harmony Patching

- **Setup**: The mod requires the Harmony library (`brrainz.harmony`) for modifying the vanilla RimWorld behavior.
- **Patch Implementation**: A Harmony patch is implemented in the `Map_MapPostTick.cs` file to ensure that map defogging occurs right after the map's regular post-tick processes.
- **Patch Type**: The `Postfix` method is used to apply functionality after the original game method runs, thereby ensuring the map is fully loaded before defogging occurs.

## Suggestions for Copilot

- **Consistent Naming**: Ensure classes and methods adhere to naming conventions for better clarity and maintainability.
- **Harmony Tips**: Suggest utilizing Harmony’s documentation to explore more advanced patching techniques if needed.
- **Error Handling**: Implement comprehensive logging within the Harmony patched methods to aid in debugging and tracking issues related to map defogging.
- **Expandable Features**: Suggest areas for potential mod expansion, such as conditional fog removal based on game difficulty or selected storyteller.

This mod provides a significant quality-of-life improvement for RimWorld players by stripping away one of the more challenging aspects of exploration, allowing players to focus on other strategic elements of the game. This document should guide Copilot in maintaining compatibility and expanding the mod’s functionality within the larger RimWorld ecosystem.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

