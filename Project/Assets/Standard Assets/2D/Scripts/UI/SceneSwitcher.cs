using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
	public GameObject Options;
	public GameObject Menu;
	

    public void start()
	{
		Options.SetActive(false);
		
	}
    public void Click()
    {
		Application.LoadLevel(1);
        
    }
	public void Exit()
    {
		Application.Quit();
        
    }

}
