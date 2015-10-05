using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	private LineRenderer tracer;
	public Transform spawn;
	public Gun gun;
	// Use this for initialization
	void Start () {
		if (GetComponent<LineRenderer>()) {
			tracer = GetComponent<LineRenderer>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Shoot() {
		Ray ray = new Ray (spawn.position, spawn.forward);
		RaycastHit hit;
		
		float shotDistance = 20;
		/*else if (hit.collider.gameObject.name == "Cube" ) {
					if (wallD == true) {
					Destroy(hit.collider.gameObject);
				}
				}*/
		
		if (Physics.Raycast (ray, out hit, shotDistance)) {
			shotDistance = hit.distance;
			if (hit.collider.GetComponent<P2> ()) {
				hit.collider.GetComponent<P2> ().health.TakeDamage (3);
				//Destroy(newProjectile);
			} else if ((hit.collider.GetComponent<PlayerController> ())) {
				hit.collider.GetComponent<PlayerController> ().health.TakeDamage (3);
				//Destroy(newProjectile);
				
			}
			if (tracer) {
				StartCoroutine ("RenderTracer", ray.direction * shotDistance);
			}
		}
		gun.currentAmmo -= 1;
	}

	IEnumerator RenderTracer(Vector3 hitPoint) {
		tracer.enabled = true;
		tracer.SetPosition(0,spawn.position);
		tracer.SetPosition(1,spawn.position + hitPoint);
		yield return new WaitForSeconds(.019f);
		tracer.enabled = false;
	}
}
