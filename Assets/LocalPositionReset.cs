using System;
using UnityEngine;

public class LocalPositionReset : MonoBehaviour
{
    public void Reset()
    {
        transform.localPosition = Vector3.zero;
    }
}
