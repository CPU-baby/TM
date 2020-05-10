using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using UnityEngine.EventSystems;
using System.Collections.Specialized;

public class TimerFirtst : MonoBehaviour
{
    public static float time;
    public GameObject Obj;

    // Start is called before the first frame update
    void Start()
    {
        time = 5f;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (time != 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
                SceneManager.LoadScene("OnestageScene");
            }
        }

        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = (t + 1).ToString();

    
    }
}
