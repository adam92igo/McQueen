using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinishMulti : MonoBehaviour
{
	public GameObject LapPanel;
	public GameObject Panel;
	public GameObject MiniMap;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;

	void OnTriggerEnter()
	{
		LapPanel.SetActive(false);
		Panel.SetActive(false);
		MiniMap.SetActive(false);
		GameObject[] go = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
		go = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject c in go)
		{
			c.SetActive(false);
			c.GetComponent<CarController>().enabled = false;
			c.GetComponent<CarUserControl>().enabled = false;
			c.SetActive(true);
			c.GetComponent<AudioSource>().enabled = false;

		}

		CompleteTrig.SetActive(false);
		//car_Controller.motorForce = 0.0f;
		LevelMusic.SetActive(false);
		FinishMusic.Play();
	}

}