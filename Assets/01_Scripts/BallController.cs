using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;
    private Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        LaunchBall();
    }

    void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        Vector2 dir = new Vector2(x, y).normalized;
        rb.velocity = dir * speed;
    }

    public void ResetBall()
    {
        transform.position = startPos;
        LaunchBall();
    }
}
