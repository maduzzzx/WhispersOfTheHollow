using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    public float speed = 5f;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
    }
}