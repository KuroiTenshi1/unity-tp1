using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongrateZone : MonoBehaviour
{
    public GameObject UiObject;
    private void Start()
    {
        UiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Marble"))
            UiObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        Destroy(other.gameObject);
    }
}
