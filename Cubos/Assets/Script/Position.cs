using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

	public GameObject objtS;
	public GameObject objtC1;
	public GameObject objtC2;
	public GameObject objtC3;
	public GameObject objtC4;
	
	void Start (){

		objtC1.transform.position = new Vector3(objtS.transform.position.x - 100, objtC1.transform.position.y, objtS.transform.position.z);
		objtC2.transform.position = new Vector3(objtS.transform.position.x, objtC2.transform.position.y, objtS.transform.position.z+100);
		objtC3.transform.position = new Vector3(objtS.transform.position.x +100, objtC3.transform.position.y, objtS.transform.position.z);
		objtC4.transform.position = new Vector3(objtS.transform.position.x, objtC4.transform.position.y, objtS.transform.position.z -100);

	}

	void Update (){

		if (Input.GetButtonDown ("Jump")) {

			Vector3 aux = new Vector3(objtC1.transform.position.x, objtC1.transform.position.y, objtC1.transform.position.z);

			objtC1.transform.position = new Vector3(objtC2.transform.position.x, objtC2.transform.position.y, objtC2.transform.position.z);
			objtC2.transform.position = new Vector3(objtC3.transform.position.x, objtC3.transform.position.y, objtC3.transform.position.z);
			objtC3.transform.position = new Vector3(objtC4.transform.position.x, objtC4.transform.position.y, objtC4.transform.position.z);
			objtC4.transform.position = aux;

		}
	}
}
