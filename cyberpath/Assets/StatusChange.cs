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
        // èuà⁄ï®ëÃìûç≈êVìIêÆêîì_è„ãé
        transform.position = new Vector3((int)transform.localPosition.x,
                                         (int)transform.localPosition.y,
                                         (int)transform.localPosition.z);
        transform.eulerAngles = new Vector3(0, 0, 0);
        //å≈íË
        rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionX |
                                RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionY |
                                RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionZ;
    }
}
