using UnityEngine.SceneManagement;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        float newSpeed = PlayerPrefs.GetFloat("pinSpeed");
        speed = newSpeed;
    }

    private void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            Lives.CurrentLife = Lives.CurrentLife - 1;
            //FindObjectOfType<GameManager>().EndGame();
            //SceneManager.LoadScene("Credit Screen");
        } else if (Lives.CurrentLife <= 0)
        {
            SceneManager.LoadScene("Credit Screen");
        }
    }

}
