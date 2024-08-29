using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    private bool isBlue;
    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        // Set the gizmo color
        Gizmos.color = Color.blue;
        isBlue = true;

        Vector3 gizmoPosition = transform.position;

        for (int i = 0; i < 8; i++)
        {
            gizmoPosition.y = i;
            for(int j = 0;  j < 8; j++)
            {
                gizmoPosition.x = j;
                Gizmos.DrawWireCube(gizmoPosition, new Vector3(1, 1, 1));

                if (isBlue)
                {
                    Gizmos.color = Color.white;
                    isBlue = false;
                }

                else
                {
                    Gizmos.color = Color.blue;
                    isBlue = true;
                }
            }
            if (isBlue)
            {
                Gizmos.color = Color.white;
                isBlue = false;
            }

            else
            {
                Gizmos.color = Color.blue;
                isBlue = true;
            }
        }
    }
    #endif
}
