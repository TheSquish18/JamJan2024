using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GopherScript : MonoBehaviour
{

    private bool lerp = false;
    private Vector3 startingPos;
    public GameObject typingBubbleObject;
    private int counter = 0;

    void Start()
    {
        StartCoroutine(someTime());
        startingPos = transform.position;
        startingPos += new Vector3(0, 3, 0);
        StartCoroutine(typingBubble());
    }

    void Update()
    {
        if (lerp == true && counter != 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, startingPos, Time.deltaTime*2);
            if (transform.position == startingPos)
            {
                lerp = false;
                counter += 1;
                startingPos += new Vector3(0, 3, 0);
                StartCoroutine(someTime());
            }
        }
        if (counter == 2)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                counter += 1;
                StartCoroutine(someTime());
            }
        }
        if (counter == 4)
        {
            SceneManager.LoadScene("Sacabambaspis");
        }
    }

    IEnumerator someTime()
    {
        yield return new WaitForSeconds(3);
        lerp = true;
    }

    IEnumerator typingBubble()
    {
        typingBubbleObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        typingBubbleObject.SetActive(false);
    }


}
