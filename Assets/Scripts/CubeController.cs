using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private cubeColDict cubeCol = new cubeColDict();
    [SerializeField]
    private cubeObjDict cubeObj = new cubeObjDict();
    [SerializeField]
    private colorMatDic colDic = new colorMatDic();
    [SerializeField]
    private faceParentDict faceParentDict = new faceParentDict();
    private Dictionary<FaceName, GameObject[]> sideGameObjectDict = new Dictionary<FaceName, GameObject[]> { };
    private Animator an;


    void Start()
    {
        an = gameObject.GetComponent<Animator>();
        InitializeCubeCol();
        UpdateFaceColor();
    }
    public void MoveAnimation(FaceName face, string trigger)
    {
        try
        {
            foreach (GameObject gameObject in sideGameObjectDict[face])
            {
                gameObject.transform.SetParent(faceParentDict[face].transform, true);
            }
            an.SetTrigger(trigger);
        }
        catch
        {
            an = gameObject.GetComponent<Animator>();
            UpdateFaceColor();
        }
    }
    public void ResetAnimation(FaceName face)
    {
        faceParentDict[face].transform.rotation = quaternion.identity;
        an.SetTrigger("Reset");
        foreach (GameObject gameObject in sideGameObjectDict[face])
        {
            gameObject.transform.SetParent(transform, true);
        }
    }

    private void UpdateFaceColor()
    {
        foreach (KeyValuePair<FaceName, faceColDict> kvp1 in cubeCol)
        {
            FaceName face = kvp1.Key;
            faceColDict colors = kvp1.Value;
            GameObject[] GOL = new GameObject[9];
            int i = 0;

            foreach (KeyValuePair<PeaceName, CubeColor> kvp2 in colors)
            {
                PeaceName peace = kvp2.Key;
                CubeColor color = kvp2.Value;
                cubeObj[face][peace].GetComponent<MeshRenderer>().material = colDic[color];
                GOL[i] = cubeObj[face][peace].transform.parent.gameObject;
                // Debug.LogError(cubeObj[face][peace].transform.parent.gameObject);
                // Debug.LogError(GOL.Length);
                i++;
            }
            // Debug.LogError(face, GOL[0]);
            sideGameObjectDict.Add(face, GOL);
        }
    }


    private void InitializeCubeCol()
    {
        cubeCol.Clear();

        cubeCol.Add(FaceName.Up, CreateColFace(CubeColor.blue));
        cubeCol.Add(FaceName.Down, CreateColFace(CubeColor.green));
        cubeCol.Add(FaceName.Left, CreateColFace(CubeColor.white));
        cubeCol.Add(FaceName.Right, CreateColFace(CubeColor.yellow));
        cubeCol.Add(FaceName.Front, CreateColFace(CubeColor.red));
        cubeCol.Add(FaceName.Back, CreateColFace(CubeColor.orange));

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
}