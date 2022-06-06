using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraSetUp : NetworkBehaviour
{
    public Camera Cameravoiture;
    public Camera CameraFinish;
    void Start()
    {
        if (!isLocalPlayer)
        {
            Cameravoiture.enabled = false;
            CameraFinish.enabled = false;
        }
        
    }
}
