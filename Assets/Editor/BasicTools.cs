using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectScript))]
[CanEditMultipleObjects]
public class BasicTools : Editor
{
    public override void OnInspectorGUI()
    {
        ObjectScript objectScript = (ObjectScript)target;

        objectScript.time = EditorGUILayout.IntSlider(objectScript.time, 0, 100, null);

        if (GUILayout.Button("Build Object"))
        {
            objectScript.BuildObject();
        }
    }
}
