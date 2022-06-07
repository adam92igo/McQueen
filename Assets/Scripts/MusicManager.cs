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
            if (Music.isPlaying)
            {
                Music.Pause();
            }
            else
            {
                Music.UnPause();
            }
            
        }
    }
}
