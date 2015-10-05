using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {


	public enum GunType {Laser,Shotgun,Auto,Pistol,Wave,Sniper,Burst};
	public GunType gunType;
	private LineRenderer tracer;
	public int maxAmmo;
	public int currentAmmo;
	public bool wallD = false;
	public Bullet bullet;
	public Projectile projectile;
	public Transform spawn;
	public float msBetweenShots = 10000;
	public float muzzleVelocity = 35;
	public float rotation=1;
	public Laser laser;
	public Shotgun shotgun;
	public Pistol pistol;
	public AutomaticGun auto;
	public Sniper sniper;
	public WaveGun waveGun;
	public BurstGun burst;
	public AmmoText ammotxt;
	public WeaponText weptxt;
	Quaternion rot;
	float nextShotTime;
	void Start(){
		if (GetComponent<LineRenderer>()) {
			tracer = GetComponent<LineRenderer>();
		}
		gunType = GunType.Pistol;
		maxAmmo = 12;
		currentAmmo = 12;
		UpdateAmmo ();
		weptxt.SetWepInfo ("Pistol");
		//ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);
	}
	public void UpdateAmmo(){
		ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);
	}

	public void Shoot() {
		if (gunType == GunType.Laser) {
			laser.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);
		} else if (gunType == GunType.Shotgun) {
			shotgun.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);

		} else if (gunType == GunType.Pistol) {
			pistol.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);

		} else if (gunType == GunType.Auto) {
			auto.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);
		} else if (gunType == GunType.Sniper) {
			sniper.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);

		} else if (gunType == GunType.Wave) {
				waveGun.Shoot ();
				checkAmmo ();
				ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);

		} else if (gunType == GunType.Burst) {
			burst.Shoot ();
			checkAmmo ();
			ammotxt.SetAmmoInfo(maxAmmo,currentAmmo);
		} 
	}
	



	public void refreshAmmo(int maximumAmmo){
		currentAmmo = maximumAmmo;
		maxAmmo = maximumAmmo;
	}
		
			
		//Debug.DrawRay(ray.origin,ray.direction * shotDistance,Color.red,1);


	public void ShootContinuous() {
		if ((gunType == GunType.Auto) || (gunType == GunType.Laser )) {
			Shoot ();
		}
	}

	public void checkAmmo(){
		if (currentAmmo <= 0) {
			weptxt.SetWepInfo ("Pistol");
			gunType=GunType.Pistol;
			refreshAmmo (12);
		}
	}

}
