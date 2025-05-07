using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;       // 따라갈 대상 (예: Player)
    public float smoothSpeed = 0.125f; // 부드럽게 따라갈 정도
    public Vector3 offset;         // 약간 떨어진 위치에서 따라가기 (필요하면 설정)

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z); // z는 그대로 유지
    }
}
