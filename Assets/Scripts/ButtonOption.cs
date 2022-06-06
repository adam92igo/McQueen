using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// pour pouvoir changer la scene
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{

	public void PlayGame()
	{
		SceneManager.LoadScene("Loading 1");
	}

	public void TrackSelect()
	{
		SceneManager.LoadScene("TrackerSelect");
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	//Below here are track selection buttons

	public void Track01()
	{
		SceneManager.LoadScene("Loading 1"); 
	}

	public void Quit()
	{
		Application.Quit();
	}
	public void PlayGameSolo()
    {
		SceneManager.LoadScene(5);
    }
	public void CreditScene()
    {
		SceneManager.LoadScene(6);
    }
}  
