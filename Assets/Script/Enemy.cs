using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private GameObject screamListener;
	private float loudness;
	public float winLoudness = 3.0f;

	// Use this for initialization
	void Start () {
		screamListener = GameObject.Find ("Scream_Listener");
	}
	
	// Update is called once per frame
	void Update () {
		loudness = screamListener.GetComponent<volume> ().loudness;
		if (loudness > winLoudness) {
			Destroy (this.gameObject);
		}
	}
}
