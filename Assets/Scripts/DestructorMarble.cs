using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorMarble : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Marble"))
            Destroy(other.gameObject);
    }
}
