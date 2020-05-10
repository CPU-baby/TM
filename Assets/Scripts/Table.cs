using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Table : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    public GameObject[] Obj = new GameObject[20];

    public Vector2 pos;//장바구니
    public Vector2 pos1;//b1
    public Vector2 pos2;//b2
    public Vector2 pos3;//b3
    public Vector2 pos4;//b4
    public Vector2 pos5;//b5
    public Vector2 pos6;//s1
    public Vector2 pos7;//s2
    public Vector2 pos8;//s3
    public Vector2 pos9;//s4
    public Vector2 pos10;//s5
    public Vector2 pos11;//d1
    public Vector2 pos12;//d2
    public Vector2 pos13;//d3
    public Vector2 pos14;//d4


    public void sf()
    {
        Obj[0] = GameObject.Find("cabinet-img");
        Obj[1] = GameObject.Find("bread1");
        Obj[2] = GameObject.Find("bread2");
        Obj[3] = GameObject.Find("bread3");
        Obj[4] = GameObject.Find("bread4");
        Obj[5] = GameObject.Find("bread5");
        Obj[6] = GameObject.Find("snack1");
        Obj[7] = GameObject.Find("snack2");
        Obj[8] = GameObject.Find("snack3");
        Obj[9] = GameObject.Find("snack4");
        Obj[10] = GameObject.Find("snack5");
        Obj[11] = GameObject.Find("drink1");
        Obj[12] = GameObject.Find("drink2");
        Obj[13] = GameObject.Find("drink3");
        Obj[14] = GameObject.Find("drink4");
     
        pos = this.Obj[0].transform.position;
        UnityEngine.Debug.Log("cabinet : "+pos.x);
        UnityEngine.Debug.Log("cabinet : " + pos.y);
        pos1 = this.Obj[1].transform.position;
        UnityEngine.Debug.Log("bread1 : " + pos1.x);
        UnityEngine.Debug.Log("bread1 : " + pos1.y);
        pos2 = this.Obj[2].transform.position;
        UnityEngine.Debug.Log("bread2 : " + pos2.x);
        UnityEngine.Debug.Log("bread2 : " + pos2.y);
        pos3 = this.Obj[3].transform.position;
        UnityEngine.Debug.Log("bread3 : " + pos3.x);
        UnityEngine.Debug.Log("bread3 : " + pos3.y);
        pos4 = this.Obj[4].transform.position;
        UnityEngine.Debug.Log("bread4 : " + pos4.x);
        UnityEngine.Debug.Log("bread4 : " + pos4.y);
        pos5 = this.Obj[5].transform.position;
        UnityEngine.Debug.Log("bread5 : " + pos5.x);
        UnityEngine.Debug.Log("bread5 : " + pos5.y);
        pos6 = this.Obj[6].transform.position;
        UnityEngine.Debug.Log("snack1 : " + pos6.x);
        UnityEngine.Debug.Log("snack1 : " + pos6.y);
        pos7 = this.Obj[7].transform.position;
        UnityEngine.Debug.Log("snack2 : " + pos7.x);
        UnityEngine.Debug.Log("snack2 : " + pos7.y);
        pos8 = this.Obj[8].transform.position;
        UnityEngine.Debug.Log("snack3 : " + pos8.x);
        UnityEngine.Debug.Log("snack3 : " + pos8.y);
        pos9 = this.Obj[9].transform.position;
        UnityEngine.Debug.Log("snack4 : " + pos9.x);
        UnityEngine.Debug.Log("snack4 : " + pos9.y);
        pos10 = this.Obj[10].transform.position;
        UnityEngine.Debug.Log("snack5 : " + pos10.x);
        UnityEngine.Debug.Log("snack5 : " + pos10.y);
        pos11 = this.Obj[11].transform.position;
        UnityEngine.Debug.Log("drink1 : " + pos11.x);
        UnityEngine.Debug.Log("drink1 : " + pos11.y);
        pos12 = this.Obj[12].transform.position;
        UnityEngine.Debug.Log("drink2 : " + pos12.x);
        UnityEngine.Debug.Log("drink2 : " + pos12.y);
        pos13 = this.Obj[13].transform.position;
        UnityEngine.Debug.Log("drink3 : " + pos13.x);
        UnityEngine.Debug.Log("drink3 : " + pos13.y);
        pos14 = this.Obj[14].transform.position;
        UnityEngine.Debug.Log("drink4 : " + pos14.x);
        UnityEngine.Debug.Log("drink4 : " + pos14.y);


       if(pos == pos1 && pos== pos6 && pos == pos11)
        {
            SceneManager.LoadScene("SuccessScene");
        }
        else
        {
            SceneManager.LoadScene("FalseScene");
        }
    }
}