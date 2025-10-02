using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;

    // Definimos las teclas de este jugador
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(upKey))
            move = 1f;
        else if (Input.GetKey(downKey))
            move = -1f;

        rb.velocity = new Vector2(0, move * speed);
    }
}
