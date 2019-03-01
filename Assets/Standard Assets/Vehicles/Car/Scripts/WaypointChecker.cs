using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointChecker : MonoBehaviour
{
    GameObject[] waypoints = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }

    public void check()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
        GameObject finish = GameObject.FindGameObjectWithTag("Finish");
        if (waypoints.Length.Equals(0))
        {
            finish.active = true;
        }

        if (GameObject.FindGameObjectWithTag("Finish").Equals(null))
        {
            print("YOU WON");
        }
    }
}
