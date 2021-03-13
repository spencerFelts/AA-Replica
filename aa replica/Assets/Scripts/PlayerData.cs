using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int score;
    public int lives;
    public string username;

    public PlayerData (SceneNavigation player)
    {
        score = Score.PinCount;
        lives = Lives.CurrentLife;
        username = Username.username;
    }
}
