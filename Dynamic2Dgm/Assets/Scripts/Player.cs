using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed;
    PhotonView view;

    public TMP_Text textName;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        textName.text = view.Owner.NickName;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (view.IsMine)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
        }

    }
}
