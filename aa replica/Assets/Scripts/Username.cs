using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    public static string username;
    public Text Name;

    public void Start()
    {
        username = PlayerPrefs.GetString("Username");
        Name.text = username;
    }

}
