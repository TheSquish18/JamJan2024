using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(makeClock());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator makeClock(){
        yield return new WaitForSeconds(19.5f);
        SceneManager.LoadScene("Octopus");

    }
}
