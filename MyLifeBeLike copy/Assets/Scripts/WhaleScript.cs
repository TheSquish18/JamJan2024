using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhaleScript : MonoBehaviour
{
    public Sprite rWhale;
    public Sprite oWhale;
    public Sprite yWhale;
    public Sprite gWhale;
    public Sprite bWhale;
    public Sprite iWhale;
    public Sprite vWhale;

    public Sprite rWhale2;
    public Sprite oWhale2;
    public Sprite yWhale2;
    public Sprite gWhale2;
    public Sprite bWhale2;
    public Sprite iWhale2;
    public Sprite vWhale2;

    public Sprite spriteUsing;

    public GameObject leftmostWhale;
    public GameObject rightmostWhale;

    private float L;
    private float R;

    private float mousePos;

    private int whalesMoved = 0;

    public static bool follow;

    void Start()
    {
        L = leftmostWhale.transform.position.x;
        R = rightmostWhale.transform.position.x;
    }

    void Update()
    {
        if (whalesMoved < 5 && whalesMoved > 0)
        {
            if (Random.value < 0.5f)
                spriteUsing = oWhale;
            else
                spriteUsing = oWhale2;
        }
        else if (whalesMoved < 10)
        {
            if (Random.value < 0.5f)
                spriteUsing = yWhale;
            else
                spriteUsing = yWhale2;
        }
        else if (whalesMoved < 15)
        {
            if (Random.value < 0.5f)
                spriteUsing = gWhale;
            else
                spriteUsing = gWhale2;
        }
        else if (whalesMoved < 20)
        {
            if (Random.value < 0.5f)
                spriteUsing = bWhale;
            else
                spriteUsing = bWhale2;
        }
        else if (whalesMoved < 25)
        {
            if (Random.value < 0.5f)
                spriteUsing = iWhale;
            else
                spriteUsing = iWhale2;
        }
        else if (whalesMoved < 30)
        {
            if (Random.value < 0.5f)
                spriteUsing = vWhale;
            else
                spriteUsing = vWhale2;
        }
        else if (whalesMoved < 35)
        {
            StartCoroutine(win());
        }

        if (transform.position.x > R)
        {
            whalesMoved += 1;
            transform.position = new Vector2(L, transform.position.y);
            GetComponent<SpriteRenderer>().sprite = spriteUsing;
        }
        if (transform.position.x < L)
        {
            whalesMoved += 1;
            transform.position = new Vector2(R, transform.position.y);
            GetComponent<SpriteRenderer>().sprite = spriteUsing;
        }

        if (follow == true)
        {
            transform.position = new Vector3(transform.position.x + (Input.mousePosition.x-mousePos)/20000, transform.position.y, transform.position.z);
        }
    }

    private void OnMouseDown()
    {
        mousePos = Input.mousePosition.x;
        WhaleScript.follow = true;
    }
    private void OnMouseUp()
    {
        WhaleScript.follow = false;
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Lobster");
    }
}
