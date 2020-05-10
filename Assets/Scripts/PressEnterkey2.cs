using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PressEnterkey2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
            SceneManager.LoadScene("Story1");
        }

        //if (Input.GetKeyUp(KeyCode.KeypadEnter))
        //    Debug.Log("Enter key was released.");
    }


}
