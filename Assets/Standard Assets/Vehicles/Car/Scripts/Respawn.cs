using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F2))
        {
            Teleport();
        }
    }

    public void Teleport()
    {
        car.transform.position = new Vector3(190,15,430);
        car.transform.rotation.Set(0,270,0,0);
        //car.transform.Rotate(0,270,0);
    }
}
