using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour {
	public Bullet bullet;
	public Transform spawn;
	Quaternion rot;
	public float muzzleVelocity = 35;
	public Gun gun;
	private float secondsBetweenShots;
	float nextPossibleShootTime;
	float rpm=60;
	// Use this for initialization
	void Start () {
		secondsBetweenShots = 60/rpm;
		bullet.setDamage (5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Shoot(){
		if (CanShoot ()) {
			rot.eulerAngles = new Vector3 (0, 15, 0);
			
			
			//rot.eulerAngles = new Vector3(0,rotation,0);
			Bullet newProjectile = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			Bullet newProjectile2 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			rot.eulerAngles = new Vector3 (0, -15, 0);
			Bullet newProjectile3 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			rot.eulerAngles = new Vector3 (0, -5, 0);
			Bullet newProjectile4 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			rot.eulerAngles = new Vector3 (0, 5, 0);
			Bullet newProjectile5 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			rot.eulerAngles = new Vector3 (0, 10, 0);
			Bullet newProjectile6 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			rot.eulerAngles = new Vector3 (0, -10, 0);
			Bullet newProjectile7 = Instantiate (bullet, spawn.position, spawn.rotation * rot) as Bullet;
			//Projectile test = Instantiate (projectile, spawn.position, spawn.rotation) as Projectile;
			newProjectile.setDamage(5);
			newProjectile2.setDamage(5);
			newProjectile3.setDamage(5);
			newProjectile4.setDamage(5);
			newProjectile5.setDamage(5);
			newProjectile6.setDamage(5);
			newProjectile7.setDamage(5);
			newProjectile.setDestroyTime(0.4f);
			newProjectile2.setDestroyTime(0.4f);
			newProjectile3.setDestroyTime(0.4f);
			newProjectile4.setDestroyTime(0.4f);
			newProjectile5.setDestroyTime(0.4f);
			newProjectile6.setDestroyTime(0.4f);
			newProjectile7.setDestroyTime(0.4f);
			newProjectile.SetSpeed (muzzleVelocity);
			newProjectile2.SetSpeed (muzzleVelocity);
			newProjectile3.SetSpeed (muzzleVelocity);
			newProjectile4.SetSpeed (muzzleVelocity);
			newProjectile5.SetSpeed (muzzleVelocity);
			newProjectile6.SetSpeed (muzzleVelocity);
			newProjectile7.SetSpeed (muzzleVelocity);

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

