using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class KingMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, 1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, -1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(0, -1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, -1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 0, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 1, 0));
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(KingMoves))]
public class KingSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        KingMoves king = (KingMoves)target;
        Handles.DrawWireCube(king.transform.position, king.borderSize);
    }

#endif
}
