using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBox : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 prevoiusPos;
    public Vector3 newPosition;
    public GameObject cube;
    public CameraFollow cameraFollow;
    public GameObject deadUI;
    // Start is called before the first frame update
    void Update()
    {
        cube.transform.position = new Vector3(target.position.x, target.position.y - 10f, target.position.z);
        if (cube.transform.position.y <= newPosition.y)
        {
            Debug.Log("Here");
            prevoiusPos = newPosition;
            cube.transform.position = prevoiusPos;

        }
        else
        {
            Debug.Log("Luy");
            newPosition = cube.transform.position;
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            
            var platformArray = GameObject.FindGameObjectsWithTag("Platform");
            foreach (var platform in platformArray)
            {
                Destroy(platform);
            }
            cameraFollow.enabled = false;
            StartCoroutine(DeadUIShow());

        }

    }

    IEnumerator DeadUIShow()
    {
        Debug.Log("sad");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("asdasd");
        Instantiate(deadUI);
        yield return new WaitForSeconds(0.1f);
        Destroy(this);

    }

}
