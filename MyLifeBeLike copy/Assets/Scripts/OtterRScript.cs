using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtterRScript : MonoBehaviour
{

    private float speed = 20;

    void Start()
    {
        StartCoroutine(wait());
    }

    void Update()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0);
        Debug.Log(Input.mouseScrollDelta);

    }

    IEnumerator speedUp()
    {
        yield return new WaitForSeconds(2);
        speed += 15;
        StartCoroutine(speedUp());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        StartCoroutine(speedUp());
    }
}
