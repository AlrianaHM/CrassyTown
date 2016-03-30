using UnityEngine;
using System.Collections;

public class Sound_Controller : MonoBehaviour {

	public GameObject aud;
	public volume vol;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 scale = new Vector3 (0, 0, 0);
		if (GameObject.FindGameObjectWithTag ("Audio")) {
			aud = GameObject.FindGameObjectWithTag ("Audio");
		}
		vol = aud.GetComponent<volume> ();
		if(vol.loudness > 5f)
			transform.localScale = new Vector3 (vol.loudness, 0.6f, 0.6f);
		else transform.localScale = new Vector3 (0f, 0.6f, 0.6f);
			
			
	}
}
