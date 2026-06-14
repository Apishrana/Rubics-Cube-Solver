using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private cubeColDict cubeCol = new cubeColDict();
    [SerializeField]
    private cubeObjDict cubeObj = new cubeObjDict();
    [SerializeField]
    private colorMatDic colDic = new colorMatDic();

    void Start()
    {
        // InitializeCube();
    }

    private void InitializeCube()
    {
        cubeCol.Clear();

        cubeCol.Add(FaceName.Up, CreateColFace(CubeColor.blue));
        cubeCol.Add(FaceName.Down, CreateColFace(CubeColor.green));
        cubeCol.Add(FaceName.Left, CreateColFace(CubeColor.white));
        cubeCol.Add(FaceName.Right, CreateColFace(CubeColor.yellow));
        cubeCol.Add(FaceName.Front, CreateColFace(CubeColor.red));
        cubeCol.Add(FaceName.Back, CreateColFace(CubeColor.orange));

        cubeObj.Clear();

        cubeObj.Add(FaceName.Up, CreateObjFace());
        cubeObj.Add(FaceName.Down, CreateObjFace());
        cubeObj.Add(FaceName.Left, CreateObjFace());
        cubeObj.Add(FaceName.Right, CreateObjFace());
        cubeObj.Add(FaceName.Front, CreateObjFace());
        cubeObj.Add(FaceName.Back, CreateObjFace());
    }

    private faceColDict CreateColFace(CubeColor color)
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
    private faceObjDict CreateObjFace()
    {
        return new faceObjDict
        {

            { PeaceName.TopLeft, gameObject },
            { PeaceName.Top, gameObject },
            { PeaceName.TopRight, gameObject },

            { PeaceName.Left, gameObject },
            { PeaceName.Middle, gameObject },
            { PeaceName.Right, gameObject },

            { PeaceName.BottomLeft, gameObject },
            { PeaceName.Bottom, gameObject },
            { PeaceName.BottomRight, gameObject }
        };
    }
}