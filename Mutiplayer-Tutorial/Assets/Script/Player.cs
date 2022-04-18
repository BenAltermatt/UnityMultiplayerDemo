using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float speed;
    public Transform t;

    PhotonView view;
    
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(view.IsMine)
        {
            Vector2 newV = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            newV = newV.normalized * speed;
            t.Translate((Vector3)newV);
        }
    }
}
