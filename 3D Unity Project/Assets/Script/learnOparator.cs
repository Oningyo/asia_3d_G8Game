using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnOparator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 1, E = 1;
    public int F = 10;
    public float G = 1.5F, H = 0.9F;
    public float hp = 50;
    public int enemy;
    public bool key;


    private void Start()
    {
#region 數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);


        C = 99 + 1;///指派是先運算右邊在左邊
        print(C);

       C = C + 1;///原始寫法
        print(D++);///後置遞增
        print(++E);///前置遞增


        // 加法指派 - * / %
        // F = F + 100;
        F += 100;
        print(F);
#endregion

#region 比較運算子
        print(G > H);
        print(G < H);
        print(G >= H);
        print(G <= H);
        print(G == H);
        print(G != H);
 #endregion

 # region 邏輯運算子
        //&&(並且)兩者皆有則為true,否則為false
        print(true && true);
        print(false && true);
        print(false && false);
        print(true && false);

        //||(或者)有true必定結果為true
        print(true || true);
        print(false || true);
        print(true || false);
        print(false || false);

        //!顛倒運算子
        print(!true);
        print(!false);
#endregion


    }

    private void Update()
    {

        print("死亡" + (hp <= 0));

        print("過關" + (key || enemy >= 5));





    }



}
