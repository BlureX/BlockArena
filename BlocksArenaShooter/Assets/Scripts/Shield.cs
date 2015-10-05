using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider collider){
		if ((collider.gameObject.name == "Bullet")) {
			gameObject.active = false;
		} else {
			gameObject.active = false;
		}
	}
}
