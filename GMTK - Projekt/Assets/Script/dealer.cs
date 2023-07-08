using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealer : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public Animator animator;

    public bool isReady = false;

    void Update()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            speed = 0f;
            animator.SetTrigger("goIdle");
            Invoke("setReady", 1.5f);
        }
    }
    public void setReady()
    {
        isReady = true;
        Destroy(this.gameObject);
    }

}
