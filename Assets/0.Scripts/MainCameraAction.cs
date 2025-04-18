using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAction : MonoBehaviour
{
    public GameObject Target;             

    public float offsetX = 0f;            // 카메라의 x좌표
    public float offsetY = 10f;           // 카메라의 y좌표
    public float offsetZ = -10f;          // 카메라의 z좌표

    public float CameraSpeed = 13f;       // 카메라의 속도
    Vector3 TargetPos;              

    void FixedUpdate()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );

        // 카메라의 움직임 부드럽게 함
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
    }
}
