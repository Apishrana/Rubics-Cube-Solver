using UnityEditor;

[CustomPropertyDrawer(typeof(cubeColDict))]
[CustomPropertyDrawer(typeof(faceColDict))]
[CustomPropertyDrawer(typeof(cubeObjDict))]
[CustomPropertyDrawer(typeof(faceObjDict))]
[CustomPropertyDrawer(typeof(colorMatDic))]
[CustomPropertyDrawer(typeof(faceParentDict))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }