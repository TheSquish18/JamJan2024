using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;

public class LobsterScript : MonoBehaviour
{
    private Sprite mainSprite;
    private Sprite clickedSprite;
    private Sprite pastaSprite;
    private bool boiling = false;
    private bool following = true;
    public GameObject pot;

    void Start()
    {
        mainSprite = GetComponent<SpriteRenderer>().sprite;
        clickedSprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
        pastaSprite = transform.GetChild(1).GetComponent<SpriteRenderer>().sprite;
        Cursor.visible = false;
        StartCoroutine(heatTheWater());
    }

    void Update()
    {
        if (following == true) {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }

        if (boiling == false)
        {
            if (Input.GetMouseButton(0))
            {
                GetComponent<SpriteRenderer>().sprite = clickedSprite;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = mainSprite;
            }
        }
    }

    IEnumerator heatTheWater()
    {
        boiling = false;
        yield return new WaitForSeconds(30);
        pot.GetComponent<Animator>().SetBool("boiling", true);
        boiling = true;
    }
    IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Gopher");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Pot")
        {
            GetComponent<SpriteRenderer>().sprite = pastaSprite;
            following = false;
            StartCoroutine(win());
        }
    }
}
