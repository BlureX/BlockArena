using UnityEngine;
using System.Collections;

public class GC2 : MonoBehaviour {
	
	private Vector3 cameraTarget;
	public P2 player2;
	private Transform target;
	
	void Start () {
			target = GameObject.FindGameObjectWithTag ("Player2").transform;
	}
	
	void Update () {
		if (target != null) {
			cameraTarget = new Vector3 (target.position.x, transform.position.y, target.position.z);
			transform.position = Vector3.Lerp (transform.position, cameraTarget, Time.deltaTime * 8);
		}
	}
}
