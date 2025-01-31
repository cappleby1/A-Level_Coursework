using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
	public GameObject Options;
	public GameObject Menu;
	public GameObject controls;
	
	public void optionsClick()
	{
		Options.SetActive(true);
		Menu.SetActive(false);
	}
	
	public void quitClick()
	{
		Application.LoadLevel(0);
	}
	
	public void controlClick()
	{
		controls.SetActive(true);
		Menu.SetActive(false);
	}
}
