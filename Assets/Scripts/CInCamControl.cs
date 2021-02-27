using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInCamControl : MonoBehaviour
{
    private bool turnedOn = true;
    public Animator camAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" & turnedOn == true)
        {
            Debug.Log("Hi");
            turnedOn = false;
            new WaitForSeconds(15);
            camAnimator.SetBool("Triggered", true);
        }

    }
}
