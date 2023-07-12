using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDealer : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public TutorialManager tut;

    void FixedUpdate()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            speed = 0f;
            animator.SetTrigger("goIdle");
            Invoke("setReady", 2f);
        }
    }
    public void setReady()
    {
        tut.advance();
    }

}
