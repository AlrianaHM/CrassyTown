using UnityEngine;
using System.Collections;

public class Game_Controller : MonoBehaviour {

	public Transform background;
	public float zoomSpeed = 0.01f;
	private bool moving = false;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		moving = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			float scaleX = background.localScale.x;
			float scaleY = background.localScale.y;
			float scaleZ = background.localScale.z;

			background.localScale = new Vector3 (scaleX + zoomSpeed, scaleY + zoomSpeed, scaleZ + zoomSpeed);

			if (scaleX > 1.3f) {
				moving = false;
				Instantiate (enemy);
			}
		}

	}
}
