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
    public bool boiling = false;
    private bool following = true;
    public GameObject pot;
    public GameObject JustPasta;
    public bool hasPasta = false;

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

        //if (boiling == false)
        //{
            if (Input.GetMouseButton(0))
            {
                GetComponent<SpriteRenderer>().sprite = clickedSprite;
                if(!hasPasta){
                    GameObject newPasta = Instantiate(JustPasta, transform.position, Quaternion.identity);
                    newPasta.GetComponent<SpriteRenderer>().enabled = true;
                    hasPasta = true;
                }
                
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = mainSprite;
            }
        //}
    }

    IEnumerator heatTheWater()
    {
        boiling = false;
        yield return new WaitForSeconds(15);
        pot.GetComponent<Animator>().SetBool("boiling", true);
        boiling = true;
    }
    IEnumerator win()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Gopher");
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Pot" && boiling == true)
        {
            GetComponent<SpriteRenderer>().sprite = pastaSprite;
            //following = false;
            StartCoroutine(win());
        }
    }*/

    public void winEffect(){
        GetComponent<SpriteRenderer>().sprite = pastaSprite;
        StartCoroutine(win());
    }

}
