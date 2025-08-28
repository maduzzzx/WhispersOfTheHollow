using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // arraste o Player aqui pelo Inspector
    public Vector3 offset;    // distância da câmera em relação ao Player
    public float smoothSpeed = 0.125f; // suavização do movimento

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
    }
}
