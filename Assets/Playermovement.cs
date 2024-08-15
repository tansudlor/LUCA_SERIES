using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public static bool alreadyDead = false;
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject deadUI;
    public Text scoreTxt;
    int currentScore = 0;
    int previousScore = 0;
    Vector2 movement;
    Vector2 mousePos;
    public AudioSource audioSource;
    // Update is called once per frame
    private void Awake()
    {
        alreadyDead = false;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 270f;

        rb.rotation = angle;
    }

    public void ScoreUp(int score)
    {
        Debug.Log(score);
        currentScore = previousScore + score;
        previousScore = currentScore;
        Debug.Log(currentScore);
        Debug.Log(previousScore);
        scoreTxt.text = currentScore.ToString();

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.collider.tag == "Enemy")
        {
            Time.timeScale = 0f;
            deadUI.SetActive(true);
            audioSource.enabled = false;
            audioSource.gameObject.GetComponent<shooting>().enabled = false;
            alreadyDead = true;
        }



    }

    
}
