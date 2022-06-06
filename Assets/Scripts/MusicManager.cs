using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource Music;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Hello France");

            if (Music.isPlaying)
            {
                Debug.Log("Hello Word");
                Music.Pause();
            }
            else
            {
                Debug.Log("Hello Paris");
                Music.UnPause();
            }
            
        }
    }
}
