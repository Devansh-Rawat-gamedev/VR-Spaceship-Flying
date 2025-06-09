using UnityEngine;

public class Targetable : MonoBehaviour
{
    void OnEnable()
    {
    }

    void OnDisable()
    {
        RemoveTarget();
    }

    void OnDestroy()
    {
        RemoveTarget();
    }

    void RemoveTarget()
    {
        UIManager.Instance.RemoveTarget(transform);
    }
}
