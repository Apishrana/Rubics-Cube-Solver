# Rubik's Cube Unity Project

A 3D Rubik's Cube project made in Unity. The scene lets you rotate the camera around the cube, zoom in and out, and trigger standard Rubik's Cube face moves through UI buttons or the custom Unity editor tool.

## Features

- Interactive 3D Rubik's Cube built from individual cube pieces and colored face materials.
- Standard face moves: `U`, `U'`, `D`, `D'`, `L`, `L'`, `R`, `R'`, `F`, `F'`, `B`, and `B'`.
- Animated face rotations using Unity Animator triggers.
- Camera orbit controls with mouse drag.
- Camera zoom using the mouse scroll wheel.
- Custom editor overlay for testing cube moves inside the Unity Scene view.
- Serializable dictionaries for editing cube faces, colors, objects, pivots, and raycast helpers in the Inspector.
- Kociemba solver source included under `Assets/Kociemba-Unity`.

## Unity Version

This project was created with:

```text
Unity 6000.4.10f1
```

For the smoothest setup, open it with the same Unity version or a compatible Unity 6 version.

## Controls

### Play Mode

- Drag with the left mouse button to orbit the camera around the cube.
- Use the mouse scroll wheel to zoom in or out.
- Use the on-screen buttons to rotate cube faces:
    - `U` / `U'` - Up face clockwise / counter-clockwise
    - `D` / `D'` - Down face clockwise / counter-clockwise
    - `L` / `L'` - Left face clockwise / counter-clockwise
    - `R` / `R'` - Right face clockwise / counter-clockwise
    - `F` / `F'` - Front face clockwise / counter-clockwise
    - `B` / `B'` - Back face clockwise / counter-clockwise

### Editor Tool

The project includes a custom editor tool named `Rubik's Cube Tool`.

When active in the Unity editor, it shows a small `Cube Controls` panel in the Scene view with move buttons and a reset button. This is useful for testing moves without relying only on the runtime UI.

## How To Run

1. Clone or download this repository.
2. Open Unity Hub.
3. Add this project folder.
4. Open the project with Unity `6000.4.10f1` or a compatible Unity 6 version.
5. Open the scene:

```text
Assets/Scenes/SampleScene.unity
```

1. Press Play.
2. Use the UI buttons and mouse controls to interact with the cube.

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
