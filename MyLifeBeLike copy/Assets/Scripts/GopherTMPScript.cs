using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopherTMPScript : MonoBehaviour
{

    private bool lerp = false;
    private Vector2 startingPos;
    private int counter = 0;
    //private int thisNumber = 215;

    void Start()
    {
        StartCoroutine(someTime());
        startingPos = GetComponent<RectTransform>().anchoredPosition;
        startingPos += new Vector2(0, 322);
    }

    void Update()
    {
        /*if (counter == 1)
        {
            thisNumber = 108;
        }
        if (counter == 2)
        {
            thisNumber = 72;
        }
        */

        if (counter == 2)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(GetComponent<RectTransform>().anchoredPosition, startingPos, Time.deltaTime * 215);
                counter += 1;
                StartCoroutine(MovingText());
            }
        }
    }

    IEnumerator someTime()
    {
        yield return new WaitForSeconds(3);
        lerp = true;
        StartCoroutine(MovingText());
    }

    IEnumerator MovingText()
    {
        yield return new WaitForSeconds(0.00000001f);
        if (lerp == true && counter != 2)
        {
            GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(GetComponent<RectTransform>().anchoredPosition, startingPos, Time.deltaTime * 215);
            if (GetComponent<RectTransform>().anchoredPosition == startingPos)
            {
                counter += 1;
                lerp = false;
                startingPos += new Vector2(0, 322);
                StartCoroutine(someTime());
            }
            StartCoroutine(MovingText());
        }
        

    }

    
}
