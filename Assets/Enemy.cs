using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public static GameObject playerGo;
    public float moveSpeed = 5f;
    Rigidbody2D rigidbody2d;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerGo = GameObject.FindGameObjectWithTag("Player");
        player = playerGo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rigidbody2d.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveChar(movement);
    }

    void moveChar(Vector2 direction)
    {
        rigidbody2d.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    public static void Die()
    {
        playerGo.GetComponent<Playermovement>().ScoreUp(100);
    }



}
