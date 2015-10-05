using UnityEngine;
using System.Collections;

public class WaveGun : MonoBehaviour {
	public Projectile projectile;
	private float secondsBetweenShots;
	float nextPossibleShootTime;
	public Transform spawn;
	float rpm=60;
	public Gun gun;
	// Use this for initialization
	void Start () {
		secondsBetweenShots = 60/rpm;
	}
	public void Shoot(){
		if (CanShoot ()) {
			Projectile test = Instantiate (projectile, spawn.position, spawn.rotation) as Projectile;
			nextPossibleShootTime = Time.time + secondsBetweenShots;
			gun.currentAmmo-=1;
		} 
	}
	private bool CanShoot() {
		bool canShoot = true;
		
		if ((Time.time < nextPossibleShootTime)) {
			canShoot = false;
		}
		
		
		
		return canShoot;
	}
}
