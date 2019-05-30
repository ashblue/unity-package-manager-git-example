using UnityEditor;
using UnityEngine;

namespace CleverCrow.UnityPackageGitExample {
    [CustomEditor(typeof(Calculator))]
    public class CalculatorInspector : Editor {
        public override void OnInspectorGUI () {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;

            var calculator = (target as Calculator).Internal;
            if (GUILayout.Button("Add 1")) {
                calculator.Add(1);
            }
            
            EditorGUILayout.LabelField($"Total: {calculator.Total}");
        }
    }
}
