using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour    

{
   
    // Переменная скорости ходьбы
    public float speed = 4;
    // Скорость прыжка 
    public float jump = 8.0f;
    // Переменная гравитации
    public float gravity = 20.0f;
    // Переменная движения 
    private Vector3 moveDir = Vector3.zero;
    //Переменная для сокращенния ChapterController
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

         
    }
    void Update()
    {
        if (controller.isGrounded)
                {
            moveDir = new Vector3(Input.GetAxis("Horizontal")*speed, 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            moveDir.y = jump;
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

}
