using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score.text = "Score: " + Score.PinCount.ToString();
    }
}
