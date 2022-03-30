using System.Collections;
using UnityEngine;
using UnityEngine.UI; 
public class caisse : MonoBehaviour
{
    public Text TxtSpeed;
    public WheelCollider front_left;
    public WheelCollider front_right;
    public WheelCollider back_left;
    public WheelCollider back_right;

    public float Torque;
    public float Speed;
    public float MaxSpeed = 200f;
    public int Brake = 10000;
    public float CoefAcceleration = 10f;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            back_left.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAcceleration * Time.deltaTime;
            back_right.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAcceleration * Time.deltaTime;
        }

    }
}
