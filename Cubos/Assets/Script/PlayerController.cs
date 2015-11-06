using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	
	private Rigidbody rb;
	
	void Start(){
		
		rb = GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate(){
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		this.transform.Translate ( Vector3.forward * moveVertical * speed);
		this.transform.Rotate (Vector3.up * moveHorizontal * speed * 2.0f);
		
	}
}
