using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

public class PawnMoves : MonoBehaviour
{
    public Vector3 borderSize = new Vector3(0.9f, 0.9f, 0.9f);

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position + new Vector3(-0.1f, 0, 0), transform.position + new Vector3(-0.1f, 1, 0));
        Gizmos.DrawLine(transform.position + new Vector3(0.1f, 0, 0), transform.position + new Vector3(0.1f, 2, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(1, 1, 0));
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(-1, 1, 0));
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(PawnMoves))]
public class PawnSelectH : Editor
{
    public void OnSceneGUI()
    {
        Handles.color = Color.yellow;
        PawnMoves pawn = (PawnMoves)target;
        Handles.DrawWireCube(pawn.transform.position, pawn.borderSize);
    }

#endif
}
