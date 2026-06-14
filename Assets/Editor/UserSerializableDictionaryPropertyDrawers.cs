using UnityEditor;

[CustomPropertyDrawer(typeof(cubeColDict))]
[CustomPropertyDrawer(typeof(faceColDict))]
public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }