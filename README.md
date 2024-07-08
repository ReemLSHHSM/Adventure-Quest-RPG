# AdventureQuestRPG

## Overview

Welcome to AdventureQuestRPG, a console-based RPG game where you, as the player, embark on an epic quest to explore new locations, battle monsters, and emerge victorious!

## Features

- Explore various locations, discovering new places on your adventure.
- Encounter various types of monsters, including a powerful boss monster, each with their own strengths and weaknesses.
- Engage in turn-based battles using strategic attacks and defenses.
- Experience dynamic gameplay with random monster encounters, location discoveries, and item drops.
- Collect items such as potions, weapons, and armor from defeated monsters and manage your inventory.

## Gameplay

1. **Location Discovery**:
   - Players can discover new locations as they explore.
   - Each discovered location is added to the player's known locations, providing new opportunities and challenges.

2. **Battle System**:
   - Players and monsters take turns attacking each other based on their attributes.
   - Damage calculation considers attack power and defense, ensuring fair battles.
   - Defeat the boss monster to achieve a significant victory.

3. **Characters**:
   - **Player**: Customize your hero's name and attributes (health, attack power, defense).
   - **Monsters**: Encounter goblins, zombies, Skulltons, and a boss monster, each with varying difficulty.

4. **Item Drops and Inventory Management**:
   - Defeated monsters may drop items such as potions, weapons, or armor.
   - Items are stored in the player's inventory.
   - Players can choose to use a potion to increase health, equip armor to increase defense, or wield a weapon to increase attack power.

5. **Victory Conditions**:
   - Defeat the monster to win the game.
   - Handle game over scenarios when the player's health drops to zero.

## Getting Started

To run the game:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build and run the `AdventureQuestRPG` project.

Ensure you have .NET Core SDK installed on your machine for development.

## Structure

- `AdventureQuestRPG/`: Contains the game logic and main program files.
  - `Program.cs`: Entry point of the game.
  - `Characters.cs`: Defines player and monster classes.
  - `BattleSystem.cs`: Implements the battle mechanics.
  - `LocationDiscovery.cs`: Implements the location discovery mechanics.
  - `Inventory.cs`: Manages the player's inventory and item usage.
- `AdventureQuestRPGTests/`: Contains unit tests to verify game functionality.
- `README.md`: This file, providing an overview of the project.

## Contributing

Contributions are welcome! If you'd like to contribute to the AdventureQuestRPG project, fork the repository and submit a pull request with your changes.

---

Enjoy your adventure in AdventureQuestRPG!

