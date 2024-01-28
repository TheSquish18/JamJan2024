using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusScript : MonoBehaviour
{
    private bool follow = false;
    private bool test = false;
    private string tentacleName;
    //public AudioSource sockNoise;
    //public AudioSource errorNoise; ??
    private Vector3 ogPosition;

    void Start()
    {
        ogPosition = transform.position;
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
            }
            else
            {
                //errorNoise.Play();
                transform.position = ogPosition;

            }
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
}
