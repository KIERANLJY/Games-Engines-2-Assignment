using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public Transform target;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + cameraOffset;
    }
}
