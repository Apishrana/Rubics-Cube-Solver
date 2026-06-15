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
            window.position.height - panelHeight,
            panelWidth,
            panelHeight);

        GUILayout.BeginArea(
            panelRect,
            "Cube Controls",
            GUI.skin.window);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Up")) cube.MoveAnimation(FaceName.Up);
        if (GUILayout.Button("Down")) cube.MoveAnimation(FaceName.Down);
        if (GUILayout.Button("Left")) cube.MoveAnimation(FaceName.Left);

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Right")) cube.MoveAnimation(FaceName.Right);
        if (GUILayout.Button("Front")) cube.MoveAnimation(FaceName.Front);
        if (GUILayout.Button("Back")) cube.MoveAnimation(FaceName.Back);

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Reset"))
        {
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