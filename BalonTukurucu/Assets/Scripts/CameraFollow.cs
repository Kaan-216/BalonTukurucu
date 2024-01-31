using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        Quaternion currentRotation = transform.rotation;

        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x ,0f, 0f);
    }
}
