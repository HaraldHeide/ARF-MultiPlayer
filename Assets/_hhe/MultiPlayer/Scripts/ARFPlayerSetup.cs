using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class ARFPlayerSetup : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshProUGUI playerNameText;


    void Start()
    {
        GameObject go = GameObject.Find("[ARF]");
        Camera[]  _arfCameras = go.GetComponentsInChildren<Camera>();
        if (photonView.IsMine)
        {
            transform.GetComponent<ARFMovementController>().enabled = true;
            //foreach (Camera c in _arfCameras)
            //{
            //    c.enabled = true;
            //}
        }
        else
        {
            transform.GetComponent<ARFMovementController>().enabled = false;
            //foreach (Camera c in _arfCameras)
            //{
            //    c.enabled = false;
            //}
        }
        SetPlayerUI();
    }

    void SetPlayerUI()
    {
        if (playerNameText != null)
        {
            playerNameText.text = photonView.Owner.NickName;
        }
    }
}
