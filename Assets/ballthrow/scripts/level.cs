using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    public float noofbottle,ballcount;
    public GameObject unbroken,balls;
  
    private void Awake()
    {
        noofbottle = unbroken.transform.childCount;
        ballcount = balls.transform.childCount;
    }
    private void Update()
    {
        noofbottle = unbroken.transform.childCount;
        ballcount = balls.transform.childCount;
        if (noofbottle<=0)
        {
            FindObjectOfType<Gamemanager>().Gamedone();
          //  Destroy(gameObject);
        }
        if(ballcount<=0)
        {
            FindObjectOfType<Gamemanager>().gamefalied();
            //Destroy(gameObject);
        }
    }
}
