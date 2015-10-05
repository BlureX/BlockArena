using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class P2 : MonoBehaviour {
	
	// Handling
	public float rotationSpeed = 450;
	public float walkSpeed = 5;
	public float runSpeed = 8;
	public PlayerHealth health;
	public TextMesh levelText;
	public float jumpSpeed = 10;
	public bool canJump;
	float disableTimer=0;
	float disableTimer2=0;
	public Transform player;
	public bool dead=false;
	// System
	private Quaternion targetRotation;
	public PlayerController player1;
	// Components
	public Gun gun2;
	private CharacterController controller;

	//private Camera cam;
	
	void Start () {
		controller = GetComponent<CharacterController>();
		canJump = true;
		//cam = Camera.main;
	}
	
	void Update () {
		//ControlMouse();
		dead = health.dead;
		if (player1.dead == true) {
			Destroy (GameObject.FindGameObjectWithTag("Player"));
			StartCoroutine("Wait",5);
			Application.LoadLevel(3);
		}
		ControlWASD();
		//transform.Rotate(Vector3.up * Time.deltaTime * 100);
		runSpeed = walkSpeed * 2;
		if (Input.GetKeyDown(KeyCode.M)) {
			gun2.Shoot();
		}
		else if (Input.GetKey(KeyCode.M)) {
			gun2.ShootContinuous();
		}
		if (disableTimer > 0){
			disableTimer = disableTimer - Time.deltaTime;
		}
		if (disableTimer2 > 0){
			disableTimer2 = disableTimer2 - Time.deltaTime;
		}

	}
	void FixedUpdate(){
		
	}
	
	void ControlWASD() {
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal2"),0,Input.GetAxisRaw("Vertical2"));
		
		if (input != Vector3.zero) {
			targetRotation = Quaternion.LookRotation(input);
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed * Time.deltaTime);
		}
		
		Vector3 motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1)?.7f:1;
		motion *= (Input.GetButton("Run2"))?runSpeed:walkSpeed;
		motion += Vector3.up * -4;

		if ((Input.GetKeyDown (KeyCode.E))&& (disableTimer2<=0)) {
			controller.Move(motion * Time.deltaTime*50);
			disableTimer2=2f;
		} 
		controller.Move(motion * Time.deltaTime);
	}

	IEnumerator Wait(int jumpTime) {
		yield return new WaitForSeconds(jumpTime);

	}
	

	
}

