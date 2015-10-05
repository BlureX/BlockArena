using UnityEngine;
using System.Collections;

public class AutomaticGun : MonoBehaviour {
	public Bullet bullet;
	public Transform spawn;
	public float muzzleVelocity = 25;
	public Gun gun;
	// Use this for initialization


	public void Shoot(){
			Bullet newProjectile = Instantiate (bullet, spawn.position, spawn.rotation) as Bullet;
			newProjectile.setDestroyTime (2);
			newProjectile.setDamage (5);
			newProjectile.SetSpeed (muzzleVelocity);
			gun.currentAmmo -= 1;
	}
}
