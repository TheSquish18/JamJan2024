using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundaboutCorrectScript : MonoBehaviour
{
    private float speed;
    private bool start = false;
    public int speedMultiplier = 500;

    void Start()
    {
        speed = Random.value * speedMultiplier;
        StartCoroutine(wait());
    }
    void Update()
    {
        if (start == true)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        start = true;
    }
}
