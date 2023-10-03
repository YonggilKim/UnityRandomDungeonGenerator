using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour
{
    public Vector2 _size = Vector2.one * 4f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Vector2 halfSize = _size * 0.5f;
        Vector3 offset = transform.position + transform.up * halfSize.y;
        Gizmos.DrawLine(offset, offset + transform.forward);
    }
}
