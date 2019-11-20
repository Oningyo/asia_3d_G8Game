using UnityEngine;//讓Unity API 執行

public class G8Player : MonoBehaviour
{
    [Header("G8雞的控制"), Range(1, 100)]
    public int speed = 10;
    [Tooltip("選轉速度"), Range(1, 100)]
    public float trun = 20.5f;
    public bool mission = false;
    public string Name = "G8雞";

    public void action(int speed)
    {
        print("雞雞速度" + speed);

    }

    public void turn_round(float trun)
    {


        print("雞雞旋轉" + trun);


    }

    public void scream(string scream="叫")
    {


        print("雞雞叫" + scream);


    }
    public void pick (bool pick = true)
    {


        print("雞雞撿東西" + pick);


    }
    private void Target (bool complete =true)
    {


        print("任務成功" +complete );


    }



}






