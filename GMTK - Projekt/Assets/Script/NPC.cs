using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    GameObject[] npcs;

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        npcs = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject obj in npcs)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Destroy(this.gameObject);
        }
    }
}
