using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoText : MonoBehaviour {
	public Text ammoText;
	
	public void SetAmmoInfo(int totalAmmo, int ammoInMag) {
		GetComponent<Text> ().text= ammoInMag.ToString() + "/" + totalAmmo.ToString();;
	}
}
