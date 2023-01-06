using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MovementController : MonoBehaviour
{
    #region Runner Game 
    [HideInInspector]
    public bool _isRuınnerGame;
    [HideInInspector]
    public SplineFollower _splineFollower;
    #endregion
    
    
    #region Custom Editor
#if UNITY_EDITOR
    [CustomEditor(typeof(MovementController))]
    public class MovementController_Editor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector(); 

            MovementController script = (MovementController)target;

            script._isRuınnerGame = EditorGUILayout.Toggle("Runner Game", script._isRuınnerGame);
            if (script._isRuınnerGame) 
            {
                script._splineFollower = EditorGUILayout.ObjectField("Spline Follower", script._splineFollower, typeof(SplineFollower), true) as SplineFollower;
            }
        }
    }
#endif
    #endregion
}
