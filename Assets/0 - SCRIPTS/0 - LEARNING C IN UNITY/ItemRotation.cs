using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    public float rotateSpeed;
    Transform itemTransform;

    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime, Space.Self);
    }
}
