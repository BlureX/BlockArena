using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth=100f;
	public float currentHealth;
	public GameObject healthBar;
	public GameObject damageText;
	public bool dead;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setHealthBar(float health){
		float calc_Health = health/ maxHealth;
		healthBar.transform.localScale = new Vector3 (calc_Health, 
		                                              healthBar.transform.localScale.y, 
		                                              healthBar.transform.localScale.z);

	}
	public virtual void TakeDamage(int damage){
		currentHealth = currentHealth - damage;
		initDamage (damage.ToString());
		setHealthBar (currentHealth);
		if (currentHealth <= 0) {
			dead=true;
			//Destroy(transform.root.gameObject);
			//Application.LoadLevel(0);
		}
	}
	void initDamage(string text){
		GameObject temp = Instantiate (damageText)as GameObject;
		RectTransform tempRect = temp.GetComponent<RectTransform>();
		temp.transform.SetParent (transform.FindChild ("DamageCanvas"));
		tempRect.transform.localPosition = damageText.transform.localPosition;
		tempRect.transform.localScale = damageText.transform.localScale;
		tempRect.transform.localRotation = damageText.transform.localRotation;
		temp.GetComponent<Text> ().text = text;
		temp.GetComponent<Animator> ().SetTrigger ("Hit");
		Destroy (temp.gameObject, 2);
	}
}
