using UnityEngine;
using System.Collections;

public class volume : MonoBehaviour {

	public float sensitivity = 0.1f;
	public float loudness = 0;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().clip = Microphone.Start (null, true, 10, 44100);
		GetComponent<AudioSource>().loop = true;
		//GetComponent<AudioSource>().mute = true;
		while (!(Microphone.GetPosition ("AudioInputDevice") > 0 )) {
		}
		GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		loudness = GetAverageVol () * sensitivity;
		Debug.Log ("Loudness: " + loudness);
	}

	float GetAverageVol(){
		float[] data = new float[1024];
		float a = 0;
		GetComponent<AudioSource>().GetOutputData (data, 0);
		foreach (float s in data) {
			a += Mathf.Abs (s);
		}

		return a / 1024;
	}

}
