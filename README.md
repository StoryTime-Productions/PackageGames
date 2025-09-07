<p align="center">
  <a href="https://github.com/StoryTime-Productions/PackageGames" rel="noopener">
 <img width=70% src="https://github.com/user-attachments/assets/be7c3a20-3cce-4cbf-9792-c5a2a10054a3" alt="PackageGames Logo"></a>
</p>

<h3 align="center">PackageGames</h3>

<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![GitHub Issues](https://img.shields.io/github/issues/StoryTime-Productions/PackageGames.svg)](https://github.com/StoryTime-Productions/PackageGames/issues)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr/StoryTime-Productions/PackageGames.svg)](https://github.com/StoryTime-Productions/PackageGames/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

<p align="center"> PackageGames is a collection of Unity-based mobile games featuring package-themed gameplay mechanics. This repository contains three distinct games: PackageClicker (an incremental clicker game), FlappyPackage (a Flappy Bird-style arcade game), and PackageClimber (an endless climbing platformer). All games share a cohesive package delivery theme while offering unique gameplay experiences optimized for mobile devices.
    <br> 
</p>

## 📝 Table of Contents

- [About](#about)
- [Key Features](#key_features)
- [Getting Started](#getting_started)
- [Architecture](#architecture)
- [Authors](#authors)

## 🧐 About <a name = "about"></a>

PackageGames is a collection of three Unity-developed mobile games that showcase different gameplay mechanics while maintaining a consistent package delivery theme. The project demonstrates versatility in game development, featuring an incremental clicker game, an arcade-style endless runner, and a challenging platformer.

**PackageClicker** is an idle/incremental game where players click on packages to earn points, purchase upgrades, and automate their package collection process. The game includes various upgrade systems, visual effects, and progression mechanics typical of the clicker genre.

**FlappyPackage** takes inspiration from the classic Flappy Bird gameplay, reimagined with package-themed graphics and mechanics. Players navigate a package through obstacles while maintaining momentum and achieving high scores.

**PackageClimber** offers an endless climbing experience where players guide a package character up increasingly challenging vertical levels, avoiding obstacles and collecting power-ups along the way.

All three games are built using Unity 2022.3.16f1 and are optimized for mobile deployment with touch-friendly controls and responsive UI design.

## ✨ Key Features <a name = "key_features"></a>

### PackageClicker Features:

- **Incremental Gameplay**: Click-to-earn mechanics with automated package generation
- **Upgrade System**: Purchase various upgrades to increase clicking power and passive income
- **Visual Effects**: Smooth animations and particle effects using DOTween
- **Progression Tracking**: Persistent save system for player progress
- **UI Polish**: Clean, responsive interface optimized for mobile devices

### FlappyPackage Features:

- **Classic Arcade Gameplay**: Flappy Bird-inspired mechanics with package theme
- **Score System**: High score tracking with local leaderboards
- **Challenging Obstacles**: Procedurally generated obstacle courses
- **Responsive Controls**: Touch-optimized input system
- **Game Over Mechanics**: Quick restart functionality for continuous play

### PackageClimber Features:

- **Endless Climbing**: Vertical platforming with infinite level generation
- **Environment Generation**: Dynamic platform and obstacle creation
- **Character Control**: Smooth physics-based movement and jumping
- **Progressive Difficulty**: Increasing challenge as players climb higher
- **Visual Variety**: Diverse environmental themes and backgrounds

### Shared Technical Features:

- **Unity 2022.3 LTS**: Built with stable, industry-standard game engine
- **Mobile Optimization**: Performance tuned for iOS and Android devices
- **Modular Architecture**: Clean, maintainable code structure across all projects
- **TextMeshPro Integration**: High-quality text rendering for UI elements

## 🏁 Getting Started <a name = "getting_started"></a>

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them.

```bash
# Unity Hub (latest version)
# Download from: https://unity3d.com/get-unity/download

# Unity 2022.3.16f1 LTS
# Install through Unity Hub

# Git for version control
git --version
```

### Installing

A step by step series of examples that tell you how to get a development environment running.

```bash
# Clone the repository
git clone https://github.com/StoryTime-Productions/PackageGames.git

# Navigate to project directory
cd PackageGames

# Open any of the three game projects in Unity:
# - PackageClicker/
# - FlappyPackage/
# - PackageClimber/
```

### Opening in Unity

1. Launch Unity Hub
2. Click "Open" and navigate to the cloned repository
3. Select one of the three game folders (PackageClicker, FlappyPackage, or PackageClimber)
4. Unity will automatically import the project and its dependencies
5. Once imported, you can run the game by pressing the Play button in the Unity Editor

### Platform-Specific Configuration

Each game includes platform-specific optimizations:

- **Android**: APK size optimization, touch input calibration
- **iOS**: Metal rendering, device-specific performance tuning
- **Editor**: Development tools and debug features for testing

## 🏗️ Architecture <a name = "architecture"></a>

### Game Architecture

Each game follows Unity's component-based architecture with modular design principles:

**PackageClicker Architecture:**

- **GameManager**: Core game state management and scene transitions
- **PackageManager**: Handles clicking mechanics, currency, and upgrades
- **UpgradeSystem**: Manages purchase logic and upgrade effects
- **UI Components**: Modular UI elements with clean separation of concerns

**FlappyPackage Architecture:**

- **GameManager**: Scene management and game state control
- **PlayerController**: Physics-based movement and input handling
- **ScoreManager**: Score tracking and high score persistence
- **ObstacleGenerator**: Procedural obstacle creation and management

**PackageClimber Architecture:**

- **GameManager**: Overall game flow and state management
- **EnvironmentGenerator**: Dynamic platform and obstacle generation
- **PlayerMovement**: Character physics and platform interaction
- **CameraController**: Smooth camera following and boundary management

## ✍️ Authors <a name = "authors"></a>

- [@StoryTime-Productions](https://github.com/StoryTime-Productions) - Development Team
- [@Niravanaa](https://github.com/Niravanaa) - Lead Developer

### 📄 License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

### 🤝 Contributing

This is an open-source game development project. Contributions are welcome! Please feel free to submit pull requests, report bugs, or suggest new features for any of the three games.
