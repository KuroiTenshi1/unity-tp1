using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerZone : MonoBehaviour
{
    public GameObject marblePrefab;

    public GameObject map;

    private GameObject marble;

    // Start is called before the first frame update
    void Start()
    {
        marblePrefab.transform.position = transform.position;
        //marblePrefab.transform.SetParent(map.transform);
        createMarble();
    }

    private void Update()
    {
        if (IsNullOrDestroyed(marble))
            createMarble();
    }

    private void createMarble()
    {
        marble = Instantiate(marblePrefab, map.transform);
    }

    public static bool IsNullOrDestroyed(GameObject obj)
    {
        if (object.ReferenceEquals(obj, null)) return true;

        if (obj is UnityEngine.Object) return (obj as UnityEngine.Object) == null;

        return false;
    }
}