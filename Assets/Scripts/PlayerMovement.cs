using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float bounds = 5.05f;

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }
    void Move(){
        float xInput = Input.GetAxis("Horizontal");
        float newPositionX = transform.position.x + xInput * speed * Time.deltaTime;

        if(newPositionX < bounds && newPositionX > -bounds)
        {
           transform.position += new Vector3(speed * xInput * Time.deltaTime, 0f, 0f);
        }
    }
}
