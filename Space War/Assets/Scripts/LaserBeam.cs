using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    public float speed;
    public float destroyDistance;
    private Rigidbody rigidBody;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = transform.forward * speed;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (transform.position - startPos).sqrMagnitude;
        if (distance > destroyDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fighter"))
        {
            Destroy(gameObject);
        }
    }
}
