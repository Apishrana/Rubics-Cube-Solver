using UnityEditor;

[CustomPropertyDrawer(typeof(cubeColDict))]
[CustomPropertyDrawer(typeof(faceColDict))]
[CustomPropertyDrawer(typeof(cubeObjDict))]
[CustomPropertyDrawer(typeof(faceObjDict))]
[CustomPropertyDrawer(typeof(colorMatDic))]
[CustomPropertyDrawer(typeof(faceParentDict))]
[CustomPropertyDrawer(typeof(faceRcDict))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }