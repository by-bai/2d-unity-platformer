using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {

        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            //current waypoint + moving platform 
            // <.1f = almost touching
            currentWaypointIndex++; 

            if (currentWaypointIndex >= waypoints.Length) //at the last waypoint
            {
                currentWaypointIndex = 0; //restart
            }

        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime* speed);
        //(!) what does Time.deltaTime mean? it's very important, rmb to read up on this

    }
}

