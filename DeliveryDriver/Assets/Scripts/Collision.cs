using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("������������ � ���������!");    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�� ����������!");    
    }
}
