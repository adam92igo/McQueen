using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour
{

    public GameObject Dreamcar01;
    void Start()
    {
        GameObject[] go = new GameObject[GameObject.FindGameObjectsWithTag("Player").Length];
        go = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject c in go)
        {
            c.GetComponent<CarController>().enabled = true;
            c.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        }


        Dreamcar01.GetComponent<CarAIControl>().enabled = true;



    }
}

