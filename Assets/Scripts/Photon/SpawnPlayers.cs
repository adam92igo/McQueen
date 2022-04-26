using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{


    public GameObject playerPrefab;

    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    private void Start()
    {
        Vector3 randomPosition = new Vector3(x, y, z);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }

    // Update is called once per fram
}
