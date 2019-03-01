using UnityEngine;
using System.Collections;

public class CamHand : MonoBehaviour {
	public float MaxDistance = 1.5f;
	public Texture2D CursorTexture;
	public bool cursorenter;
	public bool cursor;
	public GameObject ObjectUse;
	
	// Use this for initialization
	void Start ()
	{
	}
	void Update ()
	{
		if(cursor == true)
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
