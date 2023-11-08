using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver2 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float stearSpeed = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float stear = Input.GetAxis("Horizontal") * stearSpeed * Time.deltaTime;
        transform.Translate(0, move, 0);
        transform.Rotate(0, 0, -stear);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEnter!");    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggerEnter!");
    }
}
