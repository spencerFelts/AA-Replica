using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public static int CurrentLife = SceneNavigation.StartLife;
    public Text LivesLeft;



    void Update()
    {
        LivesLeft.text = ("Lives: " + CurrentLife.ToString());

        if (CurrentLife <= 0)
        {
            LivesLeft.text = "Lives: 0";
        }
    }


}
