using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SacaScriptParent : MonoBehaviour
{
    private int numClothes = 12;

    void Update()
    {
       foreach(Transform child in transform)
        {
            if (transform.position.x > -11 && transform.position.x < -6 && transform.position.y > -33 && transform.position.y < -24)
            {
                numClothes -= 1;
            }
        }
        if (numClothes == 0) {
            StartCoroutine(win());
        }
        else
        {
            numClothes = 12;
        }
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Hare");
    }
}
