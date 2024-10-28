using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafallow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;


    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }


}