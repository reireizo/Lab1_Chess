using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PawnMoves : MonoBehaviour
{
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
