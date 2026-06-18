using System;
using UnityEngine;


public enum FaceName
{
    Up, Down, Left, Right, Front, Back
}
public enum PeaceName
{
    TopLeft = 6, Top = 7, TopRight = 8, Left = 3, Middle = 4, Right = 5, BottomLeft = 0, Bottom = 1, BottomRight = 2
}
public enum CubeColor
{
    red, green, blue, yellow, white, orange
}
[Serializable] public class cubeColDict : SerializableDictionary<FaceName, faceColDict> { }
[Serializable] public class faceColDict : SerializableDictionary<PeaceName, CubeColor> { }
[Serializable] public class cubeObjDict : SerializableDictionary<FaceName, faceObjDict> { }
[Serializable] public class faceObjDict : SerializableDictionary<PeaceName, GameObject> { }
[Serializable] public class colorMatDic : SerializableDictionary<CubeColor, Material> { }
[Serializable] public class faceParentDict : SerializableDictionary<FaceName, GameObject> { }
[Serializable] public class faceRcDict : SerializableDictionary<FaceName, GameObject> { }