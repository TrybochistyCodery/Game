using UnityEngine;
using System.Collections;

public class CamUse : MonoBehaviour {
	public CamHand bh;
	public Camera Cam;

    public GameObject realPistol;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (bh.cursorenter == true & Input.GetKeyDown ("f")) {

			Cam.enabled = true;
			Destroy (gameObject);
		    realPistol.SetActive(true);


		}
}
}