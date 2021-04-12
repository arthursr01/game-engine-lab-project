using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    public bool MoveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRight == true)
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-1 * Time.deltaTime, 0, 0);
        }

    }
}
