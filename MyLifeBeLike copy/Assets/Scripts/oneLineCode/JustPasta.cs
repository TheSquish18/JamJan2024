using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustPasta : MonoBehaviour
{
    private LobsterScript lobster;

    // Start is called before the first frame update
    void Start()
    {
        lobster = GameObject.Find("Hand").GetComponent<LobsterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "PastaDestroyer") {
            lobster.hasPasta = false;
            Destroy(gameObject);
        }
        /* if (collision.transform.name == "Pot" && lobster.boiling == true)
        {
            lobster.winEffect();
        } */
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.name == "Pot" && lobster.boiling == true)
        {
            Destroy(gameObject);
            lobster.winEffect();
        }
    }
}
