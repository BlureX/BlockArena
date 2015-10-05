using UnityEngine;
using System.Collections;

public class BurstGun : MonoBehaviour {
	public Bullet bullet;
	public Transform spawn;
	public float muzzleVelocity = 35;
	public Gun gun;
	
	private float secondsBetweenShots;
	float nextPossibleShootTime;
	float rpm=30;
	// Use this for initialization
	void Start () {
		secondsBetweenShots = 60/rpm;
	}
	
	
	public void Shoot(){
		if (CanShoot ()) {
			Bullet newProjectile = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			Bullet newProjectile2 = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			Bullet newProjectile3 = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			newProjectile.setDamage (4);
			newProjectile.SetSpeed (muzzleVelocity - 10);
			newProjectile.setDestroyTime (3);
			newProjectile2.setDamage (4);
			newProjectile2.SetSpeed (muzzleVelocity - 5);
			newProjectile2.setDestroyTime (3);
			newProjectile3.setDamage (4);
			newProjectile3.SetSpeed (muzzleVelocity);
			newProjectile3.setDestroyTime (2);
			nextPossibleShootTime = Time.time + secondsBetweenShots;
			gun.currentAmmo -= 3;
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
