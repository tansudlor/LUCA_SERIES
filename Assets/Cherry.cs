using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    public GameObject hitEffect;
    public GameShooting gameShooting;
    private void Update()
    {
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.2f);
        Destroy(gameObject);
        if (collision.collider.tag == "Enemy")
        {

            Destroy(collision.collider.gameObject);
            Enemy.Die();
        }

    }
}
