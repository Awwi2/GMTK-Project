using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;

    private void Start()
    {
        Physics2D.IgnoreCollision(GameObject.FindWithTag("Player").GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
    }
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Destroy(this.gameObject);
        }
    }
}
