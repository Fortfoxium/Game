using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour    

{
   
    // ���������� �������� ������
    public float speed = 4;
    // �������� ������ 
    public float jump = 8.0f;
    // ���������� ����������
    public float gravity = 20.0f;
    // ���������� �������� 
    private Vector3 moveDir = Vector3.zero;
    //���������� ��� ����������� ChapterController
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
