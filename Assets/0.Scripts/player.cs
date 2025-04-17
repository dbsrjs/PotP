using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    float hAxis = 0;
    float vAxis = 0;
    float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        Vector3 moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        Vector3 move = moveVec * speed * Time.deltaTime;
        rb.MovePosition(transform.position + move);

        transform.LookAt(transform.position + moveVec); //지정된 벡터를 향해서 회전시켜줌
    }
}
