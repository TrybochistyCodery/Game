using UnityEngine;
using System.Collections;

public class CamHand : MonoBehaviour {
	public float MaxDistance = 3f;
    public bool cursorenter{get; private set;}
    private bool cursor;
    private bool atPlayer = false;
    private Rigidbody rigidbody;
    private BoxCollider boxCollider;
    private GameObject weaponScript;
    public float dropForce = 250;



    // Use this for initialization
    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        
    }
	void Update ()
	{


	    if (transform.parent != null && (transform.parent.tag == "PlayerCamera" || transform.parent.tag == "Player"))
	    {
            atPlayer = true;
	        
	    }
	    else
	    {
	        atPlayer = false;
	    }

	    if (cursor == true)
		{
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			if(Vector3.Distance(transform.position, player.transform.position)< MaxDistance)
			{
				cursorenter = true;
			}
			else
			{
				cursorenter = false;
                
			}
		}

	    if (cursorenter & Input.GetKeyDown("f"))
	    {
	        if (GameObject.FindGameObjectWithTag("CurrentGun") != null)
	        {
	            GameObject difGun = GameObject.FindGameObjectWithTag("CurrentGun");
	            difGun.GetComponent<CamHand>().Drop();
                
         

	        }
	        transform.position = (GameObject.FindGameObjectWithTag("GunPlace").transform.position);
	        transform.rotation = (GameObject.FindGameObjectWithTag("GunPlace").transform.rotation);
            transform.SetParent(GameObject.FindGameObjectWithTag("PlayerCamera").transform);
            rigidbody.isKinematic = true;
	        boxCollider.enabled = false;
	        transform.gameObject.tag = "CurrentGun";



	    }

	    if (Input.GetKeyDown("q"))
	    {
            Drop();
        }

        if (atPlayer)
        {

            var a = GetComponent<Weapon>();
            a.enabled = true;



        }

	    else
	    {
	        var a = GetComponent<Weapon>();
	        a.enabled = false;
	    }
    }



    public void Drop()
    {
        if (atPlayer)
        {
            transform.parent = null;
            rigidbody.isKinematic = false;
            boxCollider.enabled = true;
            transform.gameObject.tag = "Gun";
            rigidbody.AddForce(transform.forward*dropForce);

        }
    }
    void OnMouseEnter()
	{
		cursor = true;
	}
	void OnMouseExit()
	{
		cursor = false;
		cursorenter = false;
	}
	
	void OnGUI ()
	{
		if(cursorenter == true)
		{
			GUI.Label(new Rect(Screen.width/2,Screen.height/2 + 200,80,60), "Use F");
		}

	}
}


