using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class PlayerController : MonoBehaviour{

	// Handling
	public float rotationSpeed = 450;
	public float walkSpeed = 5;
	public float runSpeed = 8;
	public PlayerHealth health;
	public P2 player2;
	public TextMesh levelText;
	public bool dead=false;

	// System
	private Quaternion targetRotation;

	// Components
	public Gun gun;
	private CharacterController controller;

	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		//ControlMouse();
		dead = health.dead;
		if (player2.dead == true) {
			Destroy (GameObject.FindGameObjectWithTag("Player2"));
			StartCoroutine("Wait",5);
			Application.LoadLevel(2);
			
		}
		ControlWASD();
		//transform.Rotate(Vector3.up * Time.deltaTime * 1000);
		runSpeed = walkSpeed * 2;
		if (Input.GetKeyDown(KeyCode.Space)) {
			gun.Shoot();
		}
		else if (Input.GetKey(KeyCode.Space)) {
			gun.ShootContinuous();
		}
	}



	void ControlWASD() {
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		
		if (input != Vector3.zero) {
			targetRotation = Quaternion.LookRotation(input);
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed * Time.deltaTime);
		}
		
		Vector3 motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1)?.7f:1;
		motion *= (Input.GetButton("Run"))?runSpeed:walkSpeed;
		motion += Vector3.up * -8;
		
		controller.Move(motion * Time.deltaTime);
	}
	IEnumerator Wait(int jumpTime) {
		yield return new WaitForSeconds(jumpTime);

	}
	
}
