using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learnmethod : MonoBehaviour
{




    private void Drive(int speed,float count,string prop ="無",string direction="前方" )
    {

        print("開車，時數"+ speed);
        print("開車加速" + count);
        print("屬性補給包" + prop);
        print("方向" + direction);
    }
    private void Start()
    {

        print("哈喽你好嗎");
        Drive(100,10.5f,"火屬性");
        Drive(200,50.8f,"冰");
        Drive(300,700.8f,"水");
        Drive(400, 500.8f, direction : "前後方");
    }



}
