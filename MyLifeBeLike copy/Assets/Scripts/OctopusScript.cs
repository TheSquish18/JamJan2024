using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;

public class OctopusScript : MonoBehaviour
{
    private bool follow = false;
    private bool test = false;
    private string tentacleName;
    //public AudioSource sockNoise;
    //public AudioSource errorNoise; ??
    private Vector3 ogPosition;
    private bool tentacleChecked = false;
    private bool win = false;

    

    void Start()
    {
        ogPosition = transform.position;
        StartCoroutine(countDown());
    }

    void Update()
    {
        if (follow == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        if (follow == false && test == true)
        {
            if (name == tentacleName)
            {
                //sockNoise.Play();
                if(tentacleChecked == false)
                {
                    ConstantStorgae.octopusTentacleCheck++;
                    tentacleChecked = true;
                }
            }
            else
            {
                //errorNoise.Play();
                transform.position = ogPosition;

            }
        }

        if(ConstantStorgae.octopusTentacleCheck == 7)
        {
            win = true;
            StartCoroutine(winEffect());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        test = true;
        tentacleName = collision.gameObject.name;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        test = false;
        tentacleName = collision.gameObject.name;
    }

    private void OnMouseDown()
    {
        follow = true;
    }
    private void OnMouseUp()
    {
        follow = false;
    }

    IEnumerator winEffect()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Otter");
    }

    IEnumerator countDown()
    {
        yield return new WaitForSeconds(45);
        SceneManager.LoadScene("Otter");
    }
}
