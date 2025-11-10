using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private GameManager gameManager;
    private float delay;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        delay = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(delay <= 0f)
        {
            Destroy(this.gameObject);
            delay = 2f;
        }
        else
        {
            delay = delay - Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().GainScore(1);
            Destroy(this.gameObject);
        }
    }

}
