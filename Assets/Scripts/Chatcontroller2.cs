using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chatcontroller2 : MonoBehaviour
{

    public Text mainText; // 대사 텍스트
    public Text nameText; // 이름 텍스트
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
            SceneManager.LoadScene("Story3");
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
        yield return StartCoroutine(NormalChat("두번째 스토리 씬입니다."));
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(NormalChat("대사를 정하세요 님아 알겟냐고ㅛ요"));
    }
}
