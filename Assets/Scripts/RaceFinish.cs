using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;
public class RaceFinish : MonoBehaviour
{
	public GameObject LapPanel;
	public GameObject MiniMap;
	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject Dream;
	public GameObject GetReady;
	public GameObject Go;
	public GameObject Finish;
	public GameObject Panel;
	public 
	void OnTriggerEnter()
	{
		this.GetComponent<BoxCollider>().enabled = false;
		LapPanel.SetActive(false);
		GetReady.SetActive(false);
		Go.SetActive(false);
		Panel.SetActive(false);
		MiniMap.SetActive(false);
		Dream.GetComponent<CarAIControl>().enabled = false;
		MyCar.SetActive(false);
		CompleteTrig.SetActive(false);
		Finish.SetActive(true);
		//car_Controller.motorForce = 0.0f;
		MyCar.GetComponent<CarController>().enabled = false;
		MyCar.GetComponent<CarUserControl>().enabled = false;
		MyCar.SetActive(true);
		FinishCam.SetActive(true);
		LevelMusic.SetActive(false);
		ViewModes.SetActive(false);
		FinishMusic.Play();
		StartCoroutine(Wa());


	}
	private IEnumerator Wa()
	{
		yield return new WaitForSeconds(20);
		SceneManager.LoadScene(6);
	}

}