using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CowScript : MonoBehaviour
{
    public AudioSource grammarlee;
    public AudioSource click;
    private int yes = 0;

    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(firstAd());
    }

    void Update()
    {
        if (!grammarlee.isPlaying)
        {
            StartCoroutine(theyListened());
        }
    }

    IEnumerator firstAd()
    {

        yield return new WaitForSeconds(5);
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;

    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        grammarlee.Stop();
        click.Play();
        yes += 1;
        if (yes == 3)
        {
            //SceneManager.LoadScene("??credit sceene i thing");
        }
        else
        {
            StartCoroutine(moreAd());
        }

    }

    IEnumerator moreAd()
    {
        yield return new WaitForSeconds(1);
        if (yes == 1)
        {
            grammarlee.pitch = Random.value + 1;
            grammarlee.reverbZoneMix = Random.value;
        }
        else
        {
            grammarlee.pitch = Random.value;
            grammarlee.reverbZoneMix = Random.value;
        }
        yield return new WaitForSeconds(5);
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    IEnumerator theyListened()
    {
        yield return new WaitForSeconds(1.2f);
        if (!grammarlee.isPlaying) { grammarlee.Play(); }
    }
}