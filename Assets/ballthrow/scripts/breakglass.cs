using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakglass : MonoBehaviour
{
    public GameObject glass;
  
    private void OnCollisionEnter(Collision collision)
    {
       if( collision.gameObject.tag=="ball")
        {
            Instantiate(glass, transform.position, transform.rotation);
            Destroy(gameObject);
            Debug.Log("broken");
        }

       
    }
}