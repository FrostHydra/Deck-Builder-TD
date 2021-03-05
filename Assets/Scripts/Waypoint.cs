using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Waypoint nextWaypoint, previousWaypoint;
    public bool endPoint;

    Waypoint GetCheckpoint(Waypoint waypoint)
    {
        if (waypoint)
        {
            return waypoint;
        }
        else
        {
            return null;
        }
    }

    public void SetNextCheckpoint(Waypoint checkpoint)
    {
        if(nextWaypoint != checkpoint)
        {
            nextWaypoint = checkpoint;
            nextWaypoint.SetPreviousCheckpoint(this);
        }
    }

    public void SetPreviousCheckpoint(Waypoint checkpoint)
    {
        if(previousWaypoint != checkpoint)
        {
            previousWaypoint = checkpoint;
            previousWaypoint.SetNextCheckpoint(this);
        }
    }

    public Waypoint GetCheckpoint()
    {
        return this;
    }

    public Waypoint GetPreviousCheckpoint()
    {
        return GetCheckpoint(previousWaypoint);
    }

    public Waypoint GetNextCheckpoint()
    {
        return GetCheckpoint(nextWaypoint);
    }

    public bool isEnd()
    {
        return endPoint;
    }
}
