# 2D Spaceship Landing Game

<img width="1206" height="737" alt="image" src="https://github.com/user-attachments/assets/b36fb259-31f8-4cfd-83b7-aea92b5d9c81" />
https://guythelevy.itch.io/gamedev-week-4-physics-game-spaceship

## Objective
Land your spaceship safely on the planet.

## Controls
- Use the **arrow keys** to move the spaceship.
  - **Up Arrow**: Move forward / thrust
  - **Left Arrow**: Rotate left
  - **Right Arrow**: Rotate right

## How to Win
- Fly the spaceship to touch the planet.
- When your spaceship touches the planet, you win the game.

## Class Relationships
- "Spaceship" is the main player. it has a RigidBody2D and Circle Collision. Movment is done by the spaceship script. It uses normal mass & gravity in unity.
- "AstroidSpawner" spawns a astroid prefab. which has a rigidbody and circlecollision too.
- The planet, too.

# Folder Structure
- Assets/Scripts stores all the scripts.
- Assets/Prefabs for prefabs (just the astroirds for now)
- Assets/PNGs for PNG files
  
## Tips
- Control your speed carefully to avoid crashing.
- Try to land on the flat part of the planet if possible.
