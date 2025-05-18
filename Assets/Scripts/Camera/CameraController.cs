using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // 要跟随的目标
    public Vector3 offset = new(0, 5, -10);
    public float followSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null) return;

        var desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * followSpeed);
        transform.LookAt(target);
    }
}