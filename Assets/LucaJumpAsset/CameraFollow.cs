using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    private void LateUpdate()
    {

        var newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);

        transform.position = newPosition;

    }
}
