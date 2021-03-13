using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNavigation : MonoBehaviour
{
    public InputField username;
    public Slider rotatorSpeed;
    public Slider time;
    public Slider pinSpeed;
    public Dropdown NumOfLives;

    public bool check = false;

    public static int StartLife;
    private int droplife;
    //public Text LivesLeft;

    

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");

        string user = username.GetComponent<InputField>().text;
        PlayerPrefs.SetString("Username", user);

        PlayerPrefs.SetFloat("rotateSpeed", rotatorSpeed.value);

        PlayerPrefs.SetFloat("pinSpeed", pinSpeed.value);

        PlayerPrefs.SetFloat("timer", time.value);

        PlayerPrefs.SetInt("lives", NumOfLives.value);

        if (check == false)
        {
            StartLife = 3;
        }
        else
        {
            StartLife = droplife;
        }

        //LivesLeft.text = ("LIVES: " + droplife.ToString());
        if (Lives.CurrentLife == 0)
        {
            Lives.CurrentLife = droplife;
        }
    }

    public void Drop()
    {
        switch (NumOfLives.value)
        {
            default:
                droplife = 3;
                check = true;
                break;
            case 1:
                droplife = 1;
                check = true;
                break;
            case 2:
                droplife = 2;
                check = true;
                break;
            case 3:
                droplife = 3;
                check = true;
                break;
        }
    }

    //void Update()
    //{
    //    LivesLeft.text = ("LIVES: " + droplife.ToString());
    //    if (Lives.CurrentLife == 0)
    //    {
    //        Lives.CurrentLife = droplife;
    //    }
    //}

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public int score;
    public int lives;
    public string user;

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        score = data.score;
        lives = data.lives;
        user = data.username;
    }
}
