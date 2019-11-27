using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        print(Random.value);
        print(Mathf.PI);

        print(Mathf.Abs(-99));///類別，靜態

        print(Random.Range(0,100));///類別，隨機

        Debug.Log("除錯中");///類別，除錯


    }
    /// <summary>
    /// 更新事件，一秒約60次，用來偵測玩家輸入
    /// </summary>
    private void Update()
    {
     

       print (Input.mousePosition);///偵測滑鼠座標

        print(Input.GetKeyDown(KeyCode.Space));///偵測空白鍵輸入，類似bool

        






    }






}
