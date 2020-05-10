using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
//using UnityEngine.EventSystems;

public class sufal : MonoBehaviour
{

    public GameObject[] Obj= new GameObject[20];
    
    public Vector3 pos;
    public void sf()
    {
        Obj[0] = GameObject.Find("cabinet-img");
        
       pos = this.Obj[0].transform.position;
        UnityEngine.Debug.Log(pos.x);
        UnityEngine.Debug.Log(pos.y);

    }


}
