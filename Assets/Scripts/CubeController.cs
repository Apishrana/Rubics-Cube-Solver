using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using Kociemba;

public class CubeController : MonoBehaviour
{
    [SerializeField] private cubeColDict cubeCol = new cubeColDict();
    [SerializeField] private cubeObjDict cubeObj = new cubeObjDict();
    [SerializeField] private colorMatDic colDic = new colorMatDic();
    [SerializeField] private faceParentDict faceParentDict = new faceParentDict();
    [SerializeField] private faceRcDict faceRcDict = new faceRcDict();
    [SerializeField] private colFaceDict colFaceDict = new colFaceDict();
    [SerializeField] private LayerMask sideLayer;
    private Dictionary<FaceName, GameObject[]> sideGameObjectDict = new Dictionary<FaceName, GameObject[]> { };
    private Animator an;
    private bool animating = false;
    public bool solving = false;
    [SerializeField] private CubeAutomove cubeAutomove;

    public void Solve()
    {
        string searchString = GetCubeStateString();
        // Debug.LogError(searchString);

        string info = "";
        string solution = SearchRunTime.solution(searchString, out info, buildTables: true);
        // string solution = Search.solution(searchString, out info);
        // Debug.Log(info);
        Debug.LogError(solution);
        string[] moves = solution.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string move in moves)
        {
            if (move[^1] == '2')
            {
                cubeAutomove.PushTOQueue(move[0].ToString());
                cubeAutomove.PushTOQueue(move[0].ToString());
                Debug.LogError(move[0].ToString());
            }
            else
                cubeAutomove.PushTOQueue(move);
            Debug.LogError(move);
        }
        solving = true;
        cubeAutomove.NextMove();
    }

    private string GetCubeStateString()
    {
        string output = "";
        FaceName[] order = { FaceName.Up, FaceName.Right, FaceName.Front, FaceName.Down, FaceName.Left, FaceName.Back };
        PeaceName[] peaceOrder = { PeaceName.TopLeft, PeaceName.Top, PeaceName.TopRight, PeaceName.Left, PeaceName.Middle, PeaceName.Right, PeaceName.BottomLeft, PeaceName.Bottom, PeaceName.BottomRight, };
        foreach (FaceName faceName in order)
        {
            faceColDict colors = cubeCol[faceName];
            string currSubStr = "";

            foreach (PeaceName peaceName in peaceOrder)
            {
                currSubStr += colFaceDict[colors[peaceName]];
            }
            output += currSubStr;
        }

        return output;
    }


    void Start()
    {
        an = gameObject.GetComponent<Animator>();
        UpdateFaceColor();
    }
    public void MoveAnimation(FaceName face, string trigger)
    {
        if (animating)
        {
            return;
        }
        try
        {
            animating = true;
            foreach (GameObject gameObject in sideGameObjectDict[face])
            {
                gameObject.transform.SetParent(faceParentDict[face].transform, true);
            }
            an.SetTrigger(trigger);
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
    void Update()
    {
        // UpdateMoveColor();
    }
    public void UpdateMoveColor()
    {
        F();
        B();
        R();
        L();
        D();
        U();
        void F()
        {
            Vector3 reyPos = faceRcDict[FaceName.Front].transform.position;
            reyPos.z -= 2;
            reyPos.y += 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.y -= 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.z += 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Front].transform.right, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Front][peaceName] = key;
                        z++;
                    }
                }
                reyPos.z -= 3;
            }
        }
        void B()
        {
            Vector3 reyPos = faceRcDict[FaceName.Back].transform.position;
            reyPos.z += 2;
            reyPos.y += 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.y -= 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.z -= 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Back].transform.right, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Back][peaceName] = key;
                        z++;
                    }
                }
                reyPos.z += 3;
            }
        }
        void L()
        {
            Vector3 reyPos = faceRcDict[FaceName.Left].transform.position;
            reyPos.x -= 2;
            reyPos.y += 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.y -= 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.x += 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Left].transform.right, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Left][peaceName] = key;
                        z++;
                    }
                }
                reyPos.x -= 3;
            }
        }
        void R()
        {
            Vector3 reyPos = faceRcDict[FaceName.Right].transform.position;
            reyPos.x += 2;
            reyPos.y += 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.y -= 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.x -= 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Right].transform.right, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Right][peaceName] = key;
                        z++;
                    }
                }
                reyPos.x += 3;
            }
        }
        void U()
        {
            Vector3 reyPos = faceRcDict[FaceName.Up].transform.position;
            reyPos.z -= 2;
            reyPos.x -= 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.x += 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.z += 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Up].transform.up, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Up][peaceName] = key;
                        z++;
                    }
                }
                reyPos.z -= 3;
            }
        }
        void D()
        {
            Vector3 reyPos = faceRcDict[FaceName.Down].transform.position;
            reyPos.z -= 2;
            reyPos.x += 2;
            RaycastHit hit;
            int z = 0;

            for (int j = 0; j < 3; j++)
            {
                reyPos.x -= 1;
                for (int i = 0; i < 3; i++)
                {
                    reyPos.z += 1;

                    if (Physics.Raycast(reyPos, faceRcDict[FaceName.Down].transform.up, out hit, Mathf.Infinity, sideLayer))
                    {
                        PeaceName peaceName = (PeaceName)z;
                        Material matchMaterial = hit.collider.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        CubeColor key = colDic.FirstOrDefault(x => x.Value == matchMaterial).Key;
                        cubeCol[FaceName.Down][peaceName] = key;
                        z++;
                    }
                }
                reyPos.z -= 3;
            }
        }
    }
    public void ResetAnimation(FaceName face)
    {
        animating = false;
        faceParentDict[face].transform.localRotation = Quaternion.identity;
        an.SetTrigger("Reset");
        foreach (GameObject gameObject in sideGameObjectDict[face])
        {
            gameObject.transform.SetParent(transform, true);
        }
        UpdateFaceColor();
        if (solving)
        {
            cubeAutomove.NextMove();
        }
    }

    private void UpdateFaceColor()
    {
        sideGameObjectDict.Clear();
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
            sideGameObjectDict[face] = GOL;
        }
    }


    // private void InitializeCubeCol()
    // {
    //     cubeCol.Clear();

    //     cubeCol.Add(FaceName.Up, CreateColFace(CubeColor.blue));
    //     cubeCol.Add(FaceName.Down, CreateColFace(CubeColor.green));
    //     cubeCol.Add(FaceName.Left, CreateColFace(CubeColor.white));
    //     cubeCol.Add(FaceName.Right, CreateColFace(CubeColor.yellow));
    //     cubeCol.Add(FaceName.Front, CreateColFace(CubeColor.red));
    //     cubeCol.Add(FaceName.Back, CreateColFace(CubeColor.orange));

    // }

    // private faceColDict CreateColFace(CubeColor color)
    // {
    //     return new faceColDict
    //     {
    //         { PeaceName.TopLeft, color },
    //         { PeaceName.Top, color },
    //         { PeaceName.TopRight, color },

    //         { PeaceName.Left, color },
    //         { PeaceName.Middle, color },
    //         { PeaceName.Right, color },

    //         { PeaceName.BottomLeft, color },
    //         { PeaceName.Bottom, color },
    //         { PeaceName.BottomRight, color }
    //     };
    // }
}