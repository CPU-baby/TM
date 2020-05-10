using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject snackObject;

    void Awake()
    {
        Instantiate(snackObject);
    }
}
