using UnityEngine;
using System.Collections;

public class RandomJump : MonoBehaviour {
	float time=0.5f;
	public Gun gun;
	float random (){
		return Random.Range (-20, 21);
	}	// Update is called once per frame
	void Update () {
		//gun.ShootBullet ();
		transform.Rotate(Vector3.up * Time.deltaTime * 10);
		time -= Time.deltaTime;
		if (time < 0) {
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.velocity = new Vector3 (random (), 0, random ());
			time=0.5f;
		}

	}
	void OnCollisionEnter(Collision collider){
		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController>().health.TakeDamage(50);
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2>().health.TakeDamage(50);
		}
	}
}
