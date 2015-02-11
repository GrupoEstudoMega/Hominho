using UnityEngine;
using System.Collections;

public class Hominho : MonoBehaviour {
	public GameObject hominho;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) 
		  hominho.rigidbody2D.AddForce (new Vector2 (3.0f, 0.0f));
		else if (Input.GetKey(KeyCode.LeftArrow)) 
			hominho.rigidbody2D.AddForce (new Vector2 (-3.0f, 0.0f));
		if (Input.GetKey (KeyCode.UpArrow))
			hominho.rigidbody2D.AddForce (new Vector2 (0.0f, 10.0f));

	}

}
