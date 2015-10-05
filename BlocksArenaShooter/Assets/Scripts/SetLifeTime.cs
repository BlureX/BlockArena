using UnityEngine;
using System.Collections;

public class SetLifeTime : MonoBehaviour {
	public float timer;
	public Object thisgameObject;
	// Use this for initialization
	void Start () {
		thisgameObject = gameObject;
		Destroy (thisgameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
