using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dealer : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public Animator animator;


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
            Invoke("setReady", 1.555f);
        }
    }
    public void setReady()
    {
        SceneManager.LoadScene("Poker Table");
    }

}
