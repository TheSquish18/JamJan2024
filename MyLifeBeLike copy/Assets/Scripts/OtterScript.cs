using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtterScript : MonoBehaviour
{
    private float speed = 0;

    void Start()
    {
        StartCoroutine(nextScene());
    }

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        speed += Input.mouseScrollDelta.y;

    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("Turtle");
    }

}
