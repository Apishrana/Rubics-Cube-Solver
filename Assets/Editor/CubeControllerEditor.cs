using UnityEngine;
using UnityEditor;
using UnityEditor.EditorTools;

[EditorTool("Rubik's Cube Tool")]
public class CubeControllerEditor : EditorTool
{
    public override void OnToolGUI(EditorWindow window)
    {
        Handles.BeginGUI();

        CubeController cube = Object.FindFirstObjectByType<CubeController>();
        if (cube == null)
        {
            Handles.EndGUI();
            return;
        }

        const float panelWidth = 300f;
        const float panelHeight = 120f;

        Rect panelRect = new Rect(
            window.position.width - panelWidth,
            window.position.height - panelHeight - 20f,
            panelWidth,
            panelHeight);

        GUILayout.BeginArea(
            panelRect,
            "Cube Controls",
            GUI.skin.window);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("U")) cube.MoveAnimation(FaceName.Up, "U");
        if (GUILayout.Button("U'")) cube.MoveAnimation(FaceName.Up, "U'");
        if (GUILayout.Button("D")) cube.MoveAnimation(FaceName.Down, "D");
        if (GUILayout.Button("D'")) cube.MoveAnimation(FaceName.Down, "D'");

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("L")) cube.MoveAnimation(FaceName.Left, "L");
        if (GUILayout.Button("L'")) cube.MoveAnimation(FaceName.Left, "L'");
        if (GUILayout.Button("R")) cube.MoveAnimation(FaceName.Right, "R");
        if (GUILayout.Button("R'")) cube.MoveAnimation(FaceName.Right, "R'");

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("F")) cube.MoveAnimation(FaceName.Front, "F");
        if (GUILayout.Button("F'")) cube.MoveAnimation(FaceName.Front, "F'");
        if (GUILayout.Button("B")) cube.MoveAnimation(FaceName.Back, "B");
        if (GUILayout.Button("B'")) cube.MoveAnimation(FaceName.Back, "B'");

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Reset"))
        {
            cube.setupLayer();
            cube.ResetAnimation(FaceName.Back);
            cube.ResetAnimation(FaceName.Front);
            cube.ResetAnimation(FaceName.Right);
            cube.ResetAnimation(FaceName.Left);
            cube.ResetAnimation(FaceName.Down);
            cube.ResetAnimation(FaceName.Up);
        }
        GUILayout.EndHorizontal();

        GUILayout.EndArea();

        Handles.EndGUI();
    }
}