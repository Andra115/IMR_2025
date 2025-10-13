using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PotionReleaseTracker : MonoBehaviour
{
    private ThrowableData data;

    void Awake()
    {
        data = GetComponent<ThrowableData>();
        GetComponent<XRGrabInteractable>().selectExited.AddListener(OnRelease);
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (data != null)
        {
            data.releasePoint = transform.position;
        }
    }
}
