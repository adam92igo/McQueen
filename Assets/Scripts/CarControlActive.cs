using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using Mirror;

public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject Dreamcar01;
    void Start()
    {
        
            CarControl.GetComponent<CarController>().enabled = true;
            CarControl.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Dreamcar01.GetComponent<CarAIControl>().enabled = true;
       

    }
}

