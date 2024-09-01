using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class KnightMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 2, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, -2, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(2, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-2, 0, 0));

        Gizmos.DrawLine(transform.position + new Vector3(-1, 2, 0), transform.position + new Vector3(1, 2, 0));
        Gizmos.DrawLine(transform.position + new Vector3(2, -1, 0), transform.position + new Vector3(2, 1, 0));
        Gizmos.DrawLine(transform.position + new Vector3(-2, -1, 0), transform.position + new Vector3(-2, 1, 0));
        Gizmos.DrawLine(transform.position + new Vector3(-1, -2, 0), transform.position + new Vector3(1, -2, 0));
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(KnightMoves))]
public class KnightSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        KnightMoves knight = (KnightMoves)target;
        Handles.DrawWireCube(knight.transform.position, knight.borderSize);
    }

#endif
}
