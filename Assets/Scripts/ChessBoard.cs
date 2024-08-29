using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    private bool isWhite;
    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        // Set the gizmo color
        Gizmos.color = Color.white;
        isWhite = true;

        Vector3 gizmoPosition = transform.position;

        for (int i = 0; i < 8; i++)
        {
            gizmoPosition.y = i;
            for(int j = 0;  j < 8; j++)
            {
                gizmoPosition.x = j;
                Gizmos.DrawCube(gizmoPosition, new Vector3(1, 1, 1));

                if (isWhite)
                {
                    Gizmos.color = Color.blue;
                    isWhite = false;
                }

                else
                {
                    Gizmos.color = Color.white;
                    isWhite = true;
                }
            }
            if (isWhite)
            {
                Gizmos.color = Color.blue;
                isWhite = false;
            }

            else
            {
                Gizmos.color = Color.white;
                isWhite = true;
            }
        }
    }
    #endif
}
