using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public float speed = 5f;
    public int jump = 10;
    public Rigidbody2D rb;
    private bool onFloor;

    void Update()
    {
        float sp = 0f;

        if (Input.GetKey(KeyCode.A)) sp -= speed;
        if (Input.GetKey(KeyCode.D)) sp += speed;

        transform.Translate(new Vector3(sp, 0, 0) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            onFloor = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f) onFloor = true;
    }
}