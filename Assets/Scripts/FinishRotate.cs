using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRotate : MonoBehaviour
{

	void Update()
	{
		transform.Rotate(0, 5, 0, Space.World);
	}
}
