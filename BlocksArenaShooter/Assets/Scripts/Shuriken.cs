using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	float speed = 10;
	public Shuriken shuriken;
	public Transform spawn;
	
	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
	void Start(){
		Destroy (gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		//transform.Rotate(Vector3.up * Time.deltaTime * 100);
	}
	void OnTriggerEnter(Collider collider){
		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController> ().health.TakeDamage (5);
			collider.gameObject.GetComponent<PlayerController> ().walkSpeed = 2;
			gameObject.active = false;
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2> ().health.TakeDamage (5);
			collider.gameObject.GetComponent<P2> ().walkSpeed = 2;
			Destroy (gameObject);
		} else {
			gameObject.active = false;
		}
	}
	public void Shoot(){
		Shuriken newShuriken = Instantiate(shuriken, spawn.position, spawn.rotation) as Shuriken;
		newShuriken.SetSpeed (10);
	}


}
