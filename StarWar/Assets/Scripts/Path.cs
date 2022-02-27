using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Vector3> wayPoints = new List<Vector3>();
    public int current = 0;
    public bool isLooped = true;

    private void PopulatePath()
    {
        wayPoints.Clear();
        foreach (Transform child in transform.GetComponentsInChildren<Transform>())
        {
            if (child != transform)
            {
                wayPoints.Add(child.position);
            }
        }
    }

    public void Awaken()
    {
        PopulatePath();
    }

    public void OnDrawGizmos() {
        PopulatePath();
        Gizmos.color = Color.white;
        for(int i = 0 ; i < wayPoints.Count ; i ++)
        {
            Gizmos.DrawSphere(wayPoints[i], 5);
            if (i != wayPoints.Count - 1)
            {
                Gizmos.DrawLine(wayPoints[i], wayPoints[i + 1]);
            }
        }

        if (isLooped)
        {
            Gizmos.DrawLine(wayPoints[wayPoints.Count - 1], wayPoints[0]);
        }
    }

    public Vector3 Next()
    {
        return wayPoints[current];
    }

    public bool IsLast()
    {
        return (current == wayPoints.Count - 1);
    }

    public void AdvanceToNext()
    {
        if (! isLooped)
        {
            if (! IsLast())
            {
                current ++;
            }
        }
        else
        {
            current = (current + 1) % wayPoints.Count;
        }
    }
}
