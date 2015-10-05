using UnityEngine;
using System.Collections;

public class PU_Boost : MonoBehaviour {

	void OnTriggerEnter(Collider collider){

		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController>().walkSpeed=10;
			gameObject.active = false;
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2>().walkSpeed=10;
			Destroy(gameObject);
		}
	}
	float random (){
		return Random.Range (-20, 21);
	}	
}
