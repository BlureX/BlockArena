using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickupGun : MonoBehaviour {
	public GameObject weaponText;
	void OnTriggerEnter(Collider collider){
		
		if ((collider.gameObject.name == "Player")) {
			float randNum=random();
			if (randNum==1){
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Auto;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(50);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Automatic");
			}else if (randNum ==2) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Laser;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(100);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Laser");
			}else if (randNum ==3) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Pistol;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(12);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Pistol");
			}else if (randNum ==4) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Shotgun;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(20);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Shotgun");
			}else if (randNum ==5) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Sniper;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(15);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Sniper");
			}else if (randNum ==6) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Wave;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(30);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Wave");
			}else if (randNum ==7) {
				collider.gameObject.GetComponent<PlayerController>().gun.gunType=Gun.GunType.Burst;
				collider.gameObject.GetComponent<PlayerController>().gun.refreshAmmo(30);
				collider.gameObject.GetComponent<PlayerController>().gun.UpdateAmmo();
				collider.gameObject.GetComponent<PlayerController>().gun.weptxt.SetWepInfo("Burst");
			}
			gameObject.active = false;
			//StartCoroutine("Respawn",20);
			
		} else if ((collider.gameObject.name == "Player2")) {
			float randNum=random();
			if (randNum==1){
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Auto;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(50);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Automatic");
	
			}else if (randNum ==2) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Laser;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(100);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Laser");
			}else if (randNum ==3) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Pistol;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(12);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Pistol");
			}else if (randNum ==4) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Shotgun;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(20);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Shotgun");
			}else if (randNum ==5) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Sniper;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(15);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Sniper");
			}else if (randNum ==6) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Wave;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(30);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Wave");
			}else if (randNum ==7) {
				collider.gameObject.GetComponent<P2>().gun2.gunType=Gun.GunType.Burst;
				collider.gameObject.GetComponent<P2>().gun2.refreshAmmo(40);
				collider.gameObject.GetComponent<P2>().gun2.UpdateAmmo();
				collider.gameObject.GetComponent<P2>().gun2.weptxt.SetWepInfo("Burst");
			}
			gameObject.active = false;
			//StartCoroutine("Respawn",20);
		}
	}
	float random (){
		return Random.Range (1, 8);
	}
	


}
