using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotating : MonoBehaviour
{

    [SerializeField] Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion quaternion = Quaternion.identity;
            Debug.Log(quaternion);
        }
    }
}
