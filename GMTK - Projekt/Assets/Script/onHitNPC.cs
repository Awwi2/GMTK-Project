using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHitNPC : MonoBehaviour
{
    public ParticleSystem particle;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            particle.Play();
        }
    }
}
