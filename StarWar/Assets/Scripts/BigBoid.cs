using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoid : MonoBehaviour
{
    public Vector3 force;
    public float mass = 1;
    public Vector3 acceleration;
    public Vector3 velocity;
    public float speed;

    public Vector3 PathFollow()
    {
        return Vector3.zero;
    }

    public Vector3 CalculateForce()
    {
        return Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        force = CalculateForce();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;
        speed = velocity.magnitude;

        if (speed > 0)
        {
            
        }
    }
}
