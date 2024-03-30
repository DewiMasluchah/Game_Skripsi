using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    [SerializeField] bool shouldRotate = false;

    void Update()
    {
        if (shouldRotate)
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}