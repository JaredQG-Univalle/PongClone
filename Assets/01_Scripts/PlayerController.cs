using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public string inputAxis; // "Vertical1" o "Vertical2"
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw(inputAxis);
        rb.velocity = new Vector2(0, move * speed);
    }
}
