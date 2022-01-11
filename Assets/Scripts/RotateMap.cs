using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMap : MonoBehaviour
{
    [Header("Speed")] public float rotateSpeed = 100;

    [Header("Limit Rot")] private float minRot = -15f;
    private float maxRot = 15f;

    private Transform _localTrans;

    void Start()
    {
    }

    // Update is called once per frame
    private float rotationX = 0f;

    //private Vector3 rotationY = new Vector3(0,0,0);
    private float rotationZ = 0f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //transform.Rotate(moveX * Vector3.left * Time.deltaTime * rotateSpeed, Space.World);
        //transform.Rotate(moveZ * Vector3.forward * Time.deltaTime * rotateSpeed, Space.World);
        //Vector3 rotation = transform.localEulerAngles;
        //Debug.Log("transform.localRotation.eulerAngles.x = "+transform.localRotation.eulerAngles.x);
        //Debug.Log("Vector3.forward = "+Vector3.forward);

        //rotationY += Input.GetAxis ("Mouse Y") * Ysensitivity;

        rotationX += moveX * Time.deltaTime * rotateSpeed;
        rotationZ += moveZ * Time.deltaTime * rotateSpeed;

        rotationX = Mathf.Clamp(rotationX, minRot, maxRot);
        rotationZ = Mathf.Clamp(rotationZ, minRot, maxRot);
        transform.localEulerAngles = new Vector3(rotationX, 0, rotationZ);


        //Debug.Log("rotation : "+rotation);
        //Debug.Log("Clamp : "+Mathf.Clamp(rotation.x, minRot, maxRot));
        //rotation.x = Mathf.Clamp(rotation.x, minRot, maxRot);
        //rotation.x = Mathf.Clamp(rotation.x, transform.localRotation.eulerAngles.x-minRot, maxRot);
        //rotation.y = Mathf.Clamp(rotation.y, transform.localRotation.eulerAngles.y-1, 1);
        //rotation.z = Mathf.Clamp(rotation.z, transform.localRotation.eulerAngles.z-minRot, maxRot);
        //transform.localRotation = Quaternion.Euler(currentRotation);
        //transform.localEulerAngles = new Vector3(rotation.x, rotation.y, rotation.z);
    }

    void LockedRotation()
    {
    }
}