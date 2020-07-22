using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARFMovementController : MonoBehaviour
{
    private Camera _arfCamera;
    private void Start()
    {
        GameObject go = GameObject.Find("[ARF]");
        _arfCamera = go.GetComponentInChildren<Camera>();
        //_arfCamera = Camera.main;
    }
    void Update()
    {
        transform.position = _arfCamera.transform.position;
        transform.rotation = Quaternion.Euler(0, _arfCamera.transform.eulerAngles.y, 0.0f);
    }
}
