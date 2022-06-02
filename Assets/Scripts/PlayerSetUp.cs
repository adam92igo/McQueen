using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerSetUp : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentstodisable;
    Camera sceneCamera;
    private void Start()
    {
        if(!isLocalPlayer)
        {
            for(int i=0;i<componentstodisable.Length;i++)
            {
                componentstodisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if (sceneCamera !=null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }
    }
    private void OnDisable()
    {
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}