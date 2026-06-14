using UnityEditor;

[CustomPropertyDrawer(typeof(cubeColDict))]
[CustomPropertyDrawer(typeof(faceColDict))]
[CustomPropertyDrawer(typeof(cubeObjDict))]
[CustomPropertyDrawer(typeof(faceObjDict))]
[CustomPropertyDrawer(typeof(colorMatDic))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }