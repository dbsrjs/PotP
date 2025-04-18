using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAction : MonoBehaviour
{
    public GameObject Target;             

    public float offsetX = 0f;            // ī�޶��� x��ǥ
    public float offsetY = 10f;           // ī�޶��� y��ǥ
    public float offsetZ = -10f;          // ī�޶��� z��ǥ

    public float CameraSpeed = 13f;       // ī�޶��� �ӵ�
    Vector3 TargetPos;              

    void FixedUpdate()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );

        // ī�޶��� ������ �ε巴�� ��
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
    }
}
