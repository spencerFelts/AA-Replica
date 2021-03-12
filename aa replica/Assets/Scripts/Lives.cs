using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int numLives;
    public Text LivesLeft;

    void Start()
    {
        numLives = PlayerPrefs.GetInt("lives");
        LivesLeft.text = "Lives: " + numLives.ToString();
    }


}
