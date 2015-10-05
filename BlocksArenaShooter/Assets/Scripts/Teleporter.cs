using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
	public int code;
	float disableTimer=0;


	
	// Update is called once per frame
	void Update () {
		if (disableTimer > 0){
			disableTimer = disableTimer - Time.deltaTime;
		}
	}
	void OnTriggerEnter(Collider collider) {
		if (((collider.gameObject.name == "Player") || (collider.gameObject.name == "Player2")) && (disableTimer<=0)) {
			foreach (Teleporter tp in FindObjectsOfType<Teleporter>()){
				if ((tp.code ==(code+1)) || (tp.code ==code-3)){
					tp.disableTimer=1;
					Vector3 position = tp.gameObject.transform.position;
					position.y+=2;
					collider.gameObject.transform.position=position;
				} 
			}
		}
	}
}
