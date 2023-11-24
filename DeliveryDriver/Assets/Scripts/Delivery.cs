using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32();
    [SerializeField] float DestroyDelay = 0.1f;

    Driver driver;
    SpriteRenderer spriteRenderer;

    private float NumOfPackages = 0;
    bool hasPackage = false;

    private void Start()
    {
        driver = GetComponent<Driver>();    
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            
            SetPackage();
            hasPackage = true;
            Destroy(collision.gameObject, DestroyDelay);
            Debug.Log("Packege picked up");
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            ResetPackage();
            hasPackage = false;
            Debug.Log("Delivered package");
        }

        if (collision.tag == "Boost")
        {
            driver.SetMoveSpeed(driver.boostSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        driver.SetMoveSpeed(driver.slowSpeed);
        Debug.Log("Ты столкнулся!");    
    }

    void ResetPackage()
    {
        spriteRenderer.color = noPackageColor;
        Debug.Log("Вы сдали " + NumOfPackages + " пакетов");
        NumOfPackages = 0;
    }
    void SetPackage()
    {
        spriteRenderer.color = hasPackageColor; 
        NumOfPackages++;
        Debug.Log(NumOfPackages);
    }
}
