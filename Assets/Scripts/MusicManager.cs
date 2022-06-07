using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(music);
            Debug.Log("Hello word");
            if (music.isPlaying)
            {
                Debug.Log("Hello France");
                music.Pause();
            }
            else
            {
                Debug.Log("Hello Paris");
                music.UnPause();
            }
            
        }
    }
}
