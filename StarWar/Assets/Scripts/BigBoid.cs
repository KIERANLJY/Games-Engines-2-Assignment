using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoid : MonoBehaviour
{
    public Vector3 force;
    public float mass;
    public Vector3 acceleration;
    public Vector3 velocity;
    public float speed;
    public float maxSpeed;
    public float wayPointDistance;

    public Path path;

    public Vector3 PathFollow()
    {
        Vector3 next = path.Next();
        if (Vector3.Distance(transform.position, next) < wayPointDistance)
        {
            path.AdvanceToNext();
        }
        return Seek(next);
    }

    public Vector3 Seek(Vector3 target)
    {
        Vector3 toTarget = target - transform.position;
        Vector3 desired = toTarget.normalized * maxSpeed;
        return (desired - velocity);
    }

    public Vector3 CalculateForce()
    {
        Vector3 f = Vector3.zero;
        f += PathFollow();
        return f;
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
        transform.position += velocity * Time.deltaTime;
        speed = velocity.magnitude;

        if (speed > 0)
        {
            transform.forward = velocity;
        }
    }
}
