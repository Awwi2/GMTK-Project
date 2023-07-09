using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHitNPC : MonoBehaviour
{
    public AudioSource coin;
    public ParticleSystem particle;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StatManager.Instance.addMoney();
            coin.Play(0);
            particle.Play();
        }
    }
}
