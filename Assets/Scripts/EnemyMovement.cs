using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Waypoint moveTarget;
    public float speed;

    void Update()
    {
        if (moveTarget != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveTarget.transform.position, speed * Time.deltaTime);
        }
    }

    public void SetWaypoint(Waypoint waypoint)
    {
        moveTarget = waypoint;
    }

}
