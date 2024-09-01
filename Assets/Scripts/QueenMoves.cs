using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QueenMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, 7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, -7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, -7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, -7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, 7, 0));
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(QueenMoves))]
public class QueenSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        QueenMoves queen = (QueenMoves)target;
        Handles.DrawWireCube(queen.transform.position, queen.borderSize);
    }

#endif
}
