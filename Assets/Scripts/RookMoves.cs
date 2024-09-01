using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RookMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, -7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, 0, 0));
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(RookMoves))]
public class RookSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        RookMoves rook = (RookMoves)target;
        Handles.DrawWireCube(rook.transform.position, rook.borderSize);
    }

#endif
}