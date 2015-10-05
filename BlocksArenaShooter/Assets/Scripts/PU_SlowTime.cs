using UnityEngine;
using System.Collections;

public class PU_SlowTime : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		
		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController>().walkSpeed=collider.gameObject.GetComponent<PlayerController>().walkSpeed *0.5f;
			collider.gameObject.GetComponent<PlayerController>().rotationSpeed*=0.5f;
			collider.gameObject.GetComponent<PlayerController>().runSpeed*=0.5f;
			collider.gameObject.GetComponent<PlayerController>().gun.muzzleVelocity*=0.5f;

			gameObject.active = false;
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2>().walkSpeed*=0.5f;
			collider.gameObject.GetComponent<P2>().rotationSpeed*=0.5f;
			collider.gameObject.GetComponent<P2>().runSpeed*=0.5f;
			collider.gameObject.GetComponent<P2>().gun2.muzzleVelocity*=0.5f;
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
