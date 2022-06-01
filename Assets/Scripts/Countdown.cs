using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject CarControls;
	public AudioSource LevelMusic;

	void Start()
	{
		StartCoroutine(CountStart());
	}


	IEnumerator CountStart()
	{
		yield return new WaitForSeconds(0f);
		LapTimer.SetActive(false);
		CountDown.GetComponent<Text>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);
		LapTimer.SetActive(false);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		LapTimer.SetActive(false);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
		LapTimer.SetActive(false);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		GoAudio.Play();
		LevelMusic.Play();
		LapTimer.SetActive(true);
		CarControls.SetActive(true);

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (LevelMusic.mute)
			{
				LevelMusic.mute = false;
			}
			else
			{
				LevelMusic.mute = true;
			}
		}
	}



}
