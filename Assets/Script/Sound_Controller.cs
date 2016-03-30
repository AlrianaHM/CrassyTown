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
		StartCoroutine (wait ());
		if (GameObject.FindGameObjectWithTag ("Audio")) {
			aud = GameObject.FindGameObjectWithTag ("Audio");
		}
		vol = aud.GetComponent<volume> ();
		if (vol.loudness > 5f) {
			vol.loudness /= 5;
			if (vol.loudness > 5f)
				vol.loudness = 4.5f;
			transform.localScale = new Vector3 (vol.loudness / 5, 0.6f, 0.6f);
		}
		else transform.localScale = new Vector3 (0f, 0.6f, 0.6f);
			
			
	}


	IEnumerator wait(){
		yield return new WaitForSeconds (1);
	}
}
