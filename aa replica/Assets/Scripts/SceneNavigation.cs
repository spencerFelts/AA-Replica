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

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");

        string user = username.GetComponent<InputField>().text;
        PlayerPrefs.SetString("Username", user);

        PlayerPrefs.SetFloat("rotateSpeed", rotatorSpeed.value);

        PlayerPrefs.SetFloat("pinSpeed", pinSpeed.value);

        PlayerPrefs.SetFloat("timer", time.value);

        PlayerPrefs.SetInt("lives", NumOfLives.value);

    }

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
}
