using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timeRemaining;
    public Text timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = PlayerPrefs.GetFloat("timer");

        //timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        timeLeft.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            timeLeft.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("Credit Screen");
        }
    }
}
