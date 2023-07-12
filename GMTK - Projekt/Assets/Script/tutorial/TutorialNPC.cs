using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialNPC : MonoBehaviour
{
    public TutorialManager manager;

    public AudioSource coin;
    public ParticleSystem particle;

    public float speed = 2f;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        Physics2D.IgnoreCollision(GameObject.FindWithTag("Player").GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            coin.Play(0);
            particle.Play();
            manager.advance();
            Destroy(this.gameObject);
        }
    }
}
