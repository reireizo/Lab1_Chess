using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMoves : MonoBehaviour
{
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
