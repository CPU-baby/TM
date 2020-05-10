using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chatcontroller1 : MonoBehaviour
{
    public Text mainText; // 대사 텍스트
    public Text nameText; // 이름 텍스트
                          // public string nextText = "다음으로 넘어가기"; // 다음으로 넘어가기 텍스트...
    public string writerText;

    private void Start()
    {
        StartCoroutine(TextPractice());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
            SceneManager.LoadScene("Story2");
        }
    }

    IEnumerator NormalChat(string narration)
    {
        int a = 0;
        writerText = "";

        // 텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            mainText.text = writerText;
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("하... 코딩 ** 지겹네... 배도 고프고 옘병할..."));
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(NormalChat("배도 고픈데 매점이나 갈까... 옘병 돈도 없는데 무슨"));
    }
}
