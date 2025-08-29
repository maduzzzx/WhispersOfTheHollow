using UnityEngine;

public class CameraFollow : MonoBehaviour

{

    public Transform target; // O personagem a ser seguido

    public float smoothSpeed = 0.125f; // Velocidade de suaviza��o

    public Vector3 offset; // Dist�ncia da c�mera em rela��o ao personagem

    void LateUpdate()

    {

        if (target != null)

        {

            Vector3 desiredPosition = target.position + offset;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);

        }

    }

}

