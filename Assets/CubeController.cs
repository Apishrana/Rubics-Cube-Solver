using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private cubeColDict cubeCol = new cubeColDict();

    void Start()
    {
        InitializeCube();
    }

    private void InitializeCube()
    {
        cubeCol.Clear();

        cubeCol.Add(FaceName.Up, CreateFace(CubeColor.blue));
        cubeCol.Add(FaceName.Down, CreateFace(CubeColor.green));
        cubeCol.Add(FaceName.Left, CreateFace(CubeColor.white));
        cubeCol.Add(FaceName.Right, CreateFace(CubeColor.yellow));
        cubeCol.Add(FaceName.Front, CreateFace(CubeColor.red));
        cubeCol.Add(FaceName.Back, CreateFace(CubeColor.orange));
    }

    private faceColDict CreateFace(CubeColor color)
    {
        return new faceColDict
        {
            { PeaceName.TopLeft, color },
            { PeaceName.Top, color },
            { PeaceName.TopRight, color },

            { PeaceName.Left, color },
            { PeaceName.Middle, color },
            { PeaceName.Right, color },

            { PeaceName.BottomLeft, color },
            { PeaceName.Bottom, color },
            { PeaceName.BottomRight, color }
        };
    }
}