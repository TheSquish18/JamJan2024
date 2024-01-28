using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacaScript : MonoBehaviour
{
    private bool follow = false;
    public AudioSource pickupSound;
    public AudioSource dropSound;

    void Update()
    {
        if (follow == true)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
    }

    private void OnMouseDown()
    {
        follow = true;
        pickupSound.Play();

    }
    private void OnMouseUp()
    {
        follow = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dropSound.Play();
    }


}
