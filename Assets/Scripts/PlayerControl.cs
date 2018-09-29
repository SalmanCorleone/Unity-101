using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

	public Rigidbody rb;
	public float speed; 
	private int count;

	public Text countText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Count: " + count.ToString ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.velocity= (movement * speed);



		
	}



	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Pickups"))
		{
			other.gameObject.SetActive (false);
			count++;
			countText.text = "Count: " + count.ToString ();
		}

		if (other.gameObject.CompareTag ("Wall")) {
		}
	}

}
