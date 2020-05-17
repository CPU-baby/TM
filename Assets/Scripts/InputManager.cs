using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField inputName;
    public InputField inputNum;

    public void checkName()
    {
        Debug.Log(inputName.text);
    }
    public void checkNum()
    {
        Debug.Log(inputName.text);
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(inputName.text.Equals(""))
            {
                Debug.Log("Empty name");
            }
            else if (inputNum.text.Equals(""))
            {
                Debug.Log("Empty num");
            }
            else
            {
                // 정보 저장하는거
                PlayerPrefs.SetString("name", inputName.text);
                PlayerPrefs.SetString("num", inputNum.text);

                /* 이게 정보 가져오는 거
                string dName = PlayerPrefs.GetString("name");
                string dNum = PlayerPrefs.GetString("num");


                Debug.Log("dName is " + dName);
                Debug.Log("dNum is " + dNum);
                */
                Debug.Log("Enter key was pressed.");
                SceneManager.LoadScene("WayScene");
            }
        }

    }
}
