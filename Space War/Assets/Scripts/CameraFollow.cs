using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform battleShip;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - battleShip.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = battleShip.transform.position + cameraOffset;
        transform.rotation = battleShip.transform.rotation;
    }
}
