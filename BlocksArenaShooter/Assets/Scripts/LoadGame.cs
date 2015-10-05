using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {
	
	public void MainMenuButton()
	{
		Application.LoadLevel(0);
	}
	public void GameButton()
	{
		Application.LoadLevel(1);
	}
}
