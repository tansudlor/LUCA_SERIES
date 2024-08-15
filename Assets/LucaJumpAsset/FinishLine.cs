using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject youWin;
    GameObject openFinish;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (openFinish == null)
            {
                openFinish = Instantiate(youWin);
            }

            var rigid2d = collision.gameObject.GetComponent<Rigidbody2D>();
            rigid2d.constraints = RigidbodyConstraints2D.FreezePosition;

            var deadBox = GameObject.Find("DeadBox");
            Destroy(deadBox);

        }
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
