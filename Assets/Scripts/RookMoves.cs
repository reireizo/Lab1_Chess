using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookMoves : MonoBehaviour
{
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
