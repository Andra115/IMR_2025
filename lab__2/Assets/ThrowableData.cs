using UnityEngine;

public class ThrowableData : MonoBehaviour
{
    public Vector3 releasePoint;

    public void SetReleasePoint(Vector3 position)
    {
        releasePoint = position;
    }
}

