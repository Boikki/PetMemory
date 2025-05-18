using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryBallBehavior : MonoBehaviour
{
    private Vector3 startPos;

    [Header("浮动设置")]
    public float floatAmplitude = 0.2f;
    public float floatSpeed = 1f;

    [Header("旋转设置")]
    public float rotationSpeed = 20f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // 上下浮动
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);

        // 自转
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}

