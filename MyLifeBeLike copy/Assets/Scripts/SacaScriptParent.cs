using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SacaScriptParent : MonoBehaviour
{
    //public int numClothes = 12;

    void Start()
    {
        StartCoroutine(countDown());
        cursor.visible = true;
    }

    void Update()
    {
       /* foreach(Transform child in transform){
        
            if (transform.position.x > -11 && transform.position.x < -6 && transform.position.y > -33 && transform.position.y < -24)
            {
                Debug.Log("In the basket");
                numClothes -= 1;
            }
        }
        if (numClothes == 0) {
            StartCoroutine(win());
        }
        else
        {
            numClothes = 12;
        } */

        if(ConstantStorgae.sacamclothCheck == 0)
        {
            StartCoroutine(win());
        }
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Cow");
    }

    IEnumerator countDown(){
        yield return new WaitForSeconds(35);
        SceneManager.LoadScene("Cow");
    }
}
