using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnIf : MonoBehaviour
{
    public bool opendoor;

    public int score = 100;

    public int combo;

    private void Start()
    {
        //規則:()為true才執行
        if (true)
        {

            print("測試!");

        }

    }

   private void Update()
    {
        ///()為true執行if,反之()為false執行else
        if(opendoor)
        {
            print("開門");
        }
        else 
        {
            print("關門");
        
        
        }
        if (score >= 60)
        {
            print("及格!");

        }
        else if(score<=60)
        {
            print("該補考啦!");


        }
        else if (score >= 40) 
        {

            print("課後輔導!");

        }
       else 
        {

            print("你重修吧");
        
        
        }
        if (combo >=150)
        {
            print("攻擊10倍!");
        }
        else if(combo>=100)
        {

            print("攻擊五倍");
        }
        else if(combo>=50)
        {
            print("攻擊2倍!");

        }



    }


}
