using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rg2d;
    float moveX;
    // Start is called before the first frame update
    void Awake()
    {
        rg2d= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rg2d.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rg2d.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }


    }
    private void FixedUpdate()
    {
        Vector2 verocityRG2D = rg2d.velocity;
        verocityRG2D.x = moveX;
        rg2d.velocity = verocityRG2D;
    }
}
