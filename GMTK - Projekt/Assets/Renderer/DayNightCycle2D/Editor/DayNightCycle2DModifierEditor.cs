using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DayNightCycle2DModifier))]
public class DayNightCycle2DModifierEditor : Editor
{
    SerializedProperty AmountLights;
    SerializedProperty Spacing;
    SerializedProperty Moon;
    SerializedProperty Sun;

    void OnEnable()
    {
        AmountLights = serializedObject.FindProperty("AmountLights");
        Spacing = serializedObject.FindProperty("Spacing");
        Moon = serializedObject.FindProperty("Moon");
        Sun = serializedObject.FindProperty("Sun");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();


        EditorGUILayout.PropertyField(AmountLights);
        EditorGUILayout.PropertyField(Spacing);
        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(Moon);
        EditorGUILayout.PropertyField(Sun);

        serializedObject.ApplyModifiedProperties();
    }
}
