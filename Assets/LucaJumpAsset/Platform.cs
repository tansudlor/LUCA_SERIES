using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            var rb2d = collision.gameObject.GetComponent<Rigidbody2D>(); 
            if (rb2d != null)
            {
                var velocity2D = rb2d.velocity;
                velocity2D.y = jumpForce;
                rb2d.velocity = velocity2D;
            }
        }
    }
}
