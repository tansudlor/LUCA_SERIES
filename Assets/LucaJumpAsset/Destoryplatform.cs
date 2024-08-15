using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryplatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DeadZone")
        {

        }
        else
        {
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame

}
