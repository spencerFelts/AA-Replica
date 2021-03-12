using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    private void Start()
    {
        float newSpeed = PlayerPrefs.GetFloat("rotateSpeed");
        speed = newSpeed;
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
