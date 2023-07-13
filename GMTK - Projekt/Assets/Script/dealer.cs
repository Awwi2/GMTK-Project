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
        //GameObject.Find("dealer_idlepoint").gameObject.GetComponent<SpawnDealer>().isSpawned = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            speed = 0f;
            animator.Play("dealer_start-idle");
            Invoke("setReady", 1.3333f);
        }
    }
    public void setReady()
    {
        SceneManager.LoadScene("Poker Table");
    }

}
