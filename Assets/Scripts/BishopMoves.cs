using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BishopMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;


        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, 7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(7, -7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, 7, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-7, -7, 0));

    }

#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(BishopMoves))]
public class BishopSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        BishopMoves bishop = (BishopMoves)target;
        Handles.DrawWireCube(bishop.transform.position, bishop.borderSize);
    }

#endif
}