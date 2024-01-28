using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(25);
        Application.Quit();
    }
}
