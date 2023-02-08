using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : MonoBehaviour
{
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    { DestroyBlock(); }
        if (Input.GetMouseButtonDown(1))    { PlaceBlock(); }
    }

    void DestroyBlock()
    {
        rigidbody.constraints = RigidbodyConstraints.None;
    }

    void PlaceBlock()
    {
        // �u�ڕ��̓��ŐV�I�����_�㋎
        transform.position = new Vector3((int)transform.localPosition.x,
                                         (int)transform.localPosition.y,
                                         (int)transform.localPosition.z);
        transform.eulerAngles = new Vector3(0, 0, 0);
        //�Œ�
        rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionX |
                                RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionY |
                                RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionZ;
    }
}
