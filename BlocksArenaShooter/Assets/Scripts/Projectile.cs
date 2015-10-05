using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float MoveSpeed = 200.0f;
	
	public float frequency = 200.0f;  // Speed of sine movement
	public float magnitude = 1000f;   // Size of sine movement
	private Vector3 axis;
	
	private Vector3 pos;
	
	void Start () {
		pos = transform.position;
		DestroyObject(gameObject, 5.0f);
		axis = transform.right;  // May or may not be the axis you want
		
	}
	
	void Update () {
		pos += transform.forward * Time.deltaTime * MoveSpeed;
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
	}

	void OnTriggerEnter(Collider collider){
		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController> ().health.TakeDamage (20);
			gameObject.active = false;
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2> ().health.TakeDamage (20);
			Destroy (gameObject);
		} else {
			gameObject.active = false;
		}
	}
}
