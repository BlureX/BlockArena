using UnityEngine;
using System.Collections;

public class Pistol : MonoBehaviour {
	public Bullet bullet;
	public Transform spawn;
	public float muzzleVelocity = 35;
	public Gun gun;
	private float secondsBetweenShots;
	float nextPossibleShootTime;
	float rpm=50;
	// Use this for initialization
	void Start () {
		secondsBetweenShots = 60/rpm;
	}


	public void Shoot(){
		if (CanShoot ()) {
			Bullet newProjectile = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			newProjectile.setDestroyTime(1);
			newProjectile.setDamage(3);

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
