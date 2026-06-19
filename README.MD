# Rubik's Cube

A 3D Rubik's Cube made in Unity.

## Features

- Camera orbit controls with mouse drag.
- Camera zoom using the mouse scroll wheel.
- Standard face moves: `U`, `U'`, `D`, `D'`, `L`, `L'`, `R`, `R'`, `F`, `F'`, `B`, and `B'`.
- Custom editor overlay for testing.

## Unity Version

This was created in Unity 6000.4.10f1

## Controls

### Play Mode

- Drag with the left click to orbit the camera around the cube.
- Use the mouse scroll wheel to zoom in / out.
- Use the on-screen buttons to rotate cube faces:
    - `U` / `U'` - Up face clockwise / anti-clockwise
    - `D` / `D'` - Down face clockwise / anti-clockwise
    - `L` / `L'` - Left face clockwise / anti-clockwise
    - `R` / `R'` - Right face clockwise / anti-clockwise
    - `F` / `F'` - Front face clockwise / anti-clockwise
    - `B` / `B'` - Back face clockwise / anti-clockwise

### Editor Tool

The project includes a custom editor tool named `Rubik's Cube Tool`.

When active in the Unity editor, it shows a small `Cube Controls` panel in the Scene view with move buttons.

## Project Structure

```text
.
├── Assets
│   ├── Animation
│   │   ├── B.anim
│   │   ├── B'.anim
│   │   ├── Cube.controller
│   │   ├── D.anim
│   │   ├── D'.anim
│   │   ├── F.anim
│   │   ├── F'.anim
│   │   ├── IDLE.anim
│   │   ├── L.anim
│   │   ├── L'.anim
│   │   ├── R.anim
│   │   ├── R'.anim
│   │   ├── U.anim
│   │   ├── U'.anim
│   ├── Editor
│   │   ├── CubeControllerEditor.cs
│   │   ├── UserSerializableDictionaryPropertyDrawers.cs
│   ├── InputSystem_Actions.inputactions
│   ├── Kociemba-Unity
│   ├── Materials
│   │   ├── CubeBG.mat
│   │   ├── CubeBLUE.mat
│   │   ├── CubeGREEN.mat
│   │   ├── CubeORANGE.mat
│   │   ├── CubeRED.mat
│   │   ├── CubeWHITE.mat
│   │   ├── CubeYELLOW.mat
│   │   ├── Unlit Quad.mat
│   ├── Scenes
│   │   ├── SampleScene.unity
│   ├── Scripts
│   │   ├── CamRotateOnDrag.cs
│   │   ├── CubeController.cs
│   │   ├── UiControler.cs
│   ├── SerializableDictionary
│   ├── Settings
│   ├── TextMesh Pro
├── Packages
├── ProjectSettings
├── README.MD
├── Rubics Cube.slnx
└── UIElementsSchema

33 directories, 511 files      Main scene
```

## Author

Created by [ApishRana](https://github.com/ApishRana)
