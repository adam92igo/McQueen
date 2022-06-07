using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinishMulti : MonoBehaviour
{
	public GameObject LapPanel;
	public GameObject MiniMap;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject Dream;
	public GameObject GetReady;
	public GameObject Go;
	public GameObject Finish;
	public GameObject Panel;

	void OnTriggerEnter()
	{
		LapPanel.SetActive(false);
		GetReady.SetActive(false);
		Go.SetActive(false);
		Panel.SetActive(false);
		MiniMap.SetActive(false);
		Dream.GetComponent<CarAIControl>().enabled = false;
		Finish.SetActive(true);
		GameObject[] go = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		go = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject c in go)
		{
			c.SetActive(false);
			c.GetComponent<CarController>().enabled = false;
			c.GetComponent<CarUserControl>().enabled = false;
			c.SetActive(true);

		}

		CompleteTrig.SetActive(false);
		//car_Controller.motorForce = 0.0f;
		LevelMusic.SetActive(false);
		StartCoroutine(Wa());
		

	}
	private IEnumerator Wa()
    {
		yield return new WaitForSeconds(12);
		SceneManager.LoadScene(6);
	}
   

}
