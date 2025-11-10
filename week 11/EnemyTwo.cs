using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private int i = 0;
    // Update is called once per frame
    void Update()
    {
        //move down
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 2f);
        //jitter left or right on a delay
        if (i == 10)
        {
            transform.Translate(new Vector3(Random.Range(-6, 6), 0, 0) * Time.deltaTime * 3f);
            i = 0;
        }
        else
        {
            i++;
        }
        if (transform.position.y < -6.5f || transform.position.x > 9f || transform.position.x <-9f)
        {
            Destroy(this.gameObject);
        }
    }
}
