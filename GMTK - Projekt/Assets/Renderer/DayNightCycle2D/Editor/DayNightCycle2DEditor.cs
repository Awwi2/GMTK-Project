using System.Collections;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
[CustomEditor(typeof(DayNightCycle2D))]
public class DayNightCycle2DEditor : Editor
{
    SerializedProperty LayertoIgnore;
    SerializedProperty Speed;
    SerializedProperty GlobalLightDay;
    SerializedProperty GlobalLightNight;
    SerializedProperty GlobalLightSpeed;

    void OnEnable()
    {
        LayertoIgnore = serializedObject.FindProperty("LayertoIgnore");
        Speed = serializedObject.FindProperty("speed");
        GlobalLightDay = serializedObject.FindProperty("GlobalLightDay");
        GlobalLightNight = serializedObject.FindProperty("GlobalLightNight");
        GlobalLightSpeed = serializedObject.FindProperty("GlobalLightSpeed");



    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();


        EditorGUILayout.PropertyField(Speed);
        EditorGUILayout.Space();
        EditorGUILayout.HelpBox("Determine the Lightintensity of the Globallight, at night ot at day.", MessageType.None);
        EditorGUILayout.PropertyField(GlobalLightDay, new GUIContent("GlobalLight at Day"));
        EditorGUILayout.PropertyField(GlobalLightNight, new GUIContent("GlobalLight at Night"));
        EditorGUILayout.PropertyField(GlobalLightSpeed, new GUIContent("Changing-Speed"));
        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(LayertoIgnore, new GUIContent("Layer to Ignore"));
        EditorGUILayout.HelpBox("This Layer will not collide with the lights.", MessageType.None);



        serializedObject.ApplyModifiedProperties();
    }
}
