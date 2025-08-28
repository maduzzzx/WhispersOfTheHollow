using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // arraste o Player aqui pelo Inspector
    public Vector3 offset;    // dist�ncia da c�mera em rela��o ao Player
    public float smoothSpeed = 0.125f; // suaviza��o do movimento

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
