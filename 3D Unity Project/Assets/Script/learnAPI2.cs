using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnAPI2 : MonoBehaviour
{

    public Transform test1;
    public Transform test2;
    // Start is called before the first frame update
    void Start()
    {

        print(test1.position);
        print(test2.position);

        ///test1.localScale = new Vector3(10, 10, 10);///手動調變數
        ///test2.localScale = Vector3.one * 5;///起始1,1,1 乘法

    }

    // Update is called once per frame
    void Update()
    {

        test1.Rotate(0, 5, 0);
        test2.Translate(0, 0, 1.5f);
    }
}
