using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlSolo : MonoBehaviour
{

    public GameObject Dreamcar01;
    public GameObject CarControl;
    void Start()
    {
        
       
            CarControl.GetComponent<CarController>().enabled = true;
            CarControl.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;


        Dreamcar01.GetComponent<CarAIControl>().enabled = true;



    }
}

