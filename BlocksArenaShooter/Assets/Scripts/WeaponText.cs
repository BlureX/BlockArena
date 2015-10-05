using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponText : MonoBehaviour {
	public Text wepTxt;
	public void SetWepInfo(string wepText) {
		GetComponent<Text> ().text = wepText;
	}
}
