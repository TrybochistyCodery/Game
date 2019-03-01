using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

public class carDeath : MonoBehaviour
{
    public GameObject car;
    public float healths;

    // Start is called before the first frame update
    void Start()
    {
        healths = 300;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            healths -= 50;
            print($"{healths}");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (healths <= 0)
        {
            Explosive exp = car.AddComponent<Explosive>();
            Destroy(car);
        }
    }
}
