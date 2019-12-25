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
    public AudioSource aud;
    public AudioClip soundbark;
    
    [Header("撿東西的位置")]
    public Rigidbody rigcatch;


    //觸發碰撞時持續執行(一秒執行60次)碰撞物件資訊
    private void OnTriggerStay(Collider other)
    {

        print(other.name);
        //如果碰撞元件的名稱為
        if (other.name == "Burger"&&ani.GetCurrentAnimatorStateInfo(0).IsName("Eat")) 
        {
            //物理.忽略碰撞
            Physics.IgnoreCollision(other, GetComponent<Collider>());
            //碰撞物件.取得元件<泛型>().連接身體=撿物品位置
            other.GetComponent<HingeJoint>().connectedBody = rigcatch;
        
        }

        if (other.name == "stonetable" && ani.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
           
            GameObject.Find("Burger").GetComponent<HingeJoint>().connectedBody = null;

        }




    }


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
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("Eat")) return;///若動畫為"eat"則跳出

        float v = Input.GetAxis("Vertical");//W1 S-1 
        ///rigi.AddForce(0, 0, speed * v);//世界座標
        rigi.AddForce(tran.forward * speed * v*Time.deltaTime);

        ani.SetBool("start walk", v != 0);

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
            aud.PlayOneShot(soundbark);

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






