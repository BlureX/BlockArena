using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour {
	public Bullet bullet2;
	public Transform spawn;
	public float muzzleVelocity = 100;
	public Gun gun;
	private float secondsBetweenShots;
	float nextPossibleShootTime;
	float rpm=20;
	// Use this for initialization
	void Start () {
		secondsBetweenShots = 60/rpm;
	}
	

	public void Shoot(){
		if (CanShoot ()) {
			Bullet newProjectile = Instantiate (bullet2, spawn.position, spawn.rotation) as Bullet;
			newProjectile.setDestroyTime (10);
			newProjectile.setDamage(40);
			newProjectile.SetSpeed (muzzleVelocity);
			nextPossibleShootTime = Time.time + secondsBetweenShots;
			gun.currentAmmo-=1;
		} 
	}
	private bool CanShoot() {
		bool canShoot = true;
		
		if (Time.time < nextPossibleShootTime) {
			canShoot = false;
		}
		return canShoot;
	}
}
