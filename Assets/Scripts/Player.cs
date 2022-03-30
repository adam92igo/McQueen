using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float speed;

    Animator anim;
    
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        view = GetComponent<PhotonView>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position += input.normalized * speed * Time.deltaTime;

            if (input==Vector3.zero)
            {
                anim.SetBool("isRunning", false);
            }
            else
            {
                anim.SetBool("isRunning", true);
            }
        }
    }
}
