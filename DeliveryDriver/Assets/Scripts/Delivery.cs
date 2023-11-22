using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            hasPackage = true;
            Debug.Log("Packege picked up");
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Delivered package");
        }
        //Debug.Log("Столкновение с триггером!");    
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Ты столкнулся!");    
    }
}
