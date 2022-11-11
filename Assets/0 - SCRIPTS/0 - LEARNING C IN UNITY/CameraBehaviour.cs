using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0, 1.2f, -2.6f);
    public Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("PlayerFPController").GetComponent<Transform>();
        Debug.Log(_target);
    }


    private void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(camOffset);
        this.transform.LookAt(_target);
    }
}
