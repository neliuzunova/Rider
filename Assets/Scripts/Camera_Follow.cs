using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = target.position + offset;
        newPosition.z = transform.position.z;

        transform.position = newPosition;
    }
}
