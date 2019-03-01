using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject waypoint;

    private bool[] checks = new bool[5];

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(waypoint);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
