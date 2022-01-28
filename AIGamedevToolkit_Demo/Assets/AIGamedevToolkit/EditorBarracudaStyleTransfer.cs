using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AIGamedevToolkit
{
#if UNITY_EDITOR
    using UnityEditor;

    [CustomEditor(typeof(InferenceFeatureBarracudaStyleTransfer))]
    public class EditorBarracudaStyleTransfer : Editor
    {
        public override void OnInspectorGUI()
        {
            InferenceFeatureBarracudaStyleTransfer scriptableInferenceFeature = (InferenceFeatureBarracudaStyleTransfer)target;

            EditorGUI.BeginChangeCheck();
            base.OnInspectorGUI();

            if (EditorGUI.EndChangeCheck())
            {
                scriptableInferenceFeature.Initialize();
            }
        }

    }
#endif
}

