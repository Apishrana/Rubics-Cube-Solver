using System;
using UnityEngine;


public enum FaceName
{
    Up, Down, Left, Right, Front, Back
}
public enum PeaceName
{
    Top, Bottom, Left, Right, Middle, TopLeft, TopRight, BottomLeft, BottomRight
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