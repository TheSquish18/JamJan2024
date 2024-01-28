using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundaboutCorrectScript : MonoBehaviour
{
    private float speed;
    private bool start = false;

    void Start()
    {
        speed = Random.value * 670;
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
        yield return new WaitForSeconds(2);
        start = true;
    }
}
