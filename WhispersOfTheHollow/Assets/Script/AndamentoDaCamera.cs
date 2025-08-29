using UnityEngine;

public class AndamentoDaCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    public float minX, maxX, minY, maxY;

    void LateUpdate()
    {
        if (target == null) return;

        // Posição desejada
        Vector3 desiredPosition = target.position + offset;

        // Suavizar movimento
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Restringir dentro dos limites
        float clampedX = Mathf.Clamp(smoothedPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}