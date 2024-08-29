using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingMoves : MonoBehaviour
{
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
