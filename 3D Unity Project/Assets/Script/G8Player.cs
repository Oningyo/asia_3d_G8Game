using UnityEngine;//讓Unity API 執行

public class G8Player : MonoBehaviour
{
    [Header("G8雞的控制"), Range(1, 2000)]
    public int speed = 10;
    [Tooltip("選轉速度"), Range(1, 200)]
    public float turn = 20.5f;
    public bool mission = false;
    public string Name = "G8雞";

    public Transform tran;
    public Rigidbody rigi;
    public Animator ani;

    private void Update()
    {

        turn_round();
        action();
        pick();
        scream();

    }

    /// <summary>
    /// 移動
    /// </summary>

    private void action()
    {
        float v = Input.GetAxis("Vertical");//W1 S-1 
        ///rigi.AddForce(0, 0, speed * v);//世界座標
        rigi.AddForce(tran.forward * speed * v*Time.deltaTime);
        print("雞雞速度" + speed);

    }

    /// <summary>
    ///旋轉 
    /// </summary>
    private void turn_round()
    {
        float h = Input.GetAxis("Horizontal");///A-1,D1

        tran.Rotate(0, turn*h * Time.deltaTime, 0);

        print("雞雞旋轉" + turn);


    }
    /// <summary>
    /// 亂叫
    /// </summary>
   
    private void pick()
    {
        if (Input.GetKeyDown("space"))
        {

            ani.SetTrigger("eat or get somthing");
        } 

        


    }
    private void scream(bool pick = true)
    {
        if (Input.GetMouseButton(0))
        {

            ani.SetTrigger("start run and papa");
        }


        print("雞雞撿東西" + pick);


    }
    private void Target (bool complete =true)
    {


        print("任務成功" +complete );


    }



}






