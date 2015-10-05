using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	float speed = 10;
	public LayerMask collisionMask;
	public bool ghostBullet=false;
	float destroyTime;
	int damage;

	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
	public void setDamage(int newDamage){
		damage = newDamage;
	}
	public void setDestroyTime(float time){
		destroyTime = time;
	}
	void Start(){
		Destroy (gameObject, destroyTime);
	}
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider collider){
		if ((collider.gameObject.name == "Player")) {
			collider.gameObject.GetComponent<PlayerController> ().health.TakeDamage (damage);
			gameObject.active = false;
		} else if ((collider.gameObject.name == "Player2")) {
			collider.gameObject.GetComponent<P2> ().health.TakeDamage (damage);
			Destroy (gameObject);
		} else {
			if (!ghostBullet){
			gameObject.active = false;
			}
		}
	}
}

