using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float offset;
    void Start()
    {
       //  transform.DOMoveX(5f,5f);
    }

   
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.DOMove(transform.position + (transform.up* offset), 0.3f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.DOMove(transform.position +(- transform.up * offset), 0.3f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.DOMove(transform.position + (-transform.right * offset), 0.3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.DOMove(transform.position + transform.right * offset, 0.3f);
        }
    }
}
