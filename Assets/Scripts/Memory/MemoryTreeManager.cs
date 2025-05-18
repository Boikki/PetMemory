using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MemoryTreeManager : MonoBehaviour
{
    [Header("记忆树设置")]
    public GameObject memoryTreePrefab;     // 记忆树预制体
    public Transform spawnPoint;            // 生成位置

	[Header("记忆球设置")]
	public GameObject memoryBallPrefab;
	public int numberOfBalls = 6;
	public float circleRadius = 2f;

    void Start()
    {
        GenerateMemoryTree();
    }

    public void GenerateMemoryTree()
    {
        if (memoryTreePrefab == null || spawnPoint == null)
        {
            Debug.LogWarning("记忆树预制体或生成位置未设置！");
            return;
        }

        GameObject treeInstance = Instantiate(memoryTreePrefab, spawnPoint.position, Quaternion.identity);
		SpawnMemoryBalls(treeInstance.transform);

    }

    private void SpawnMemoryBalls(Transform treeTransform)
    {
        if (memoryBallPrefab == null)
        {
            Debug.LogWarning("未设置记忆球预制体！");
            return;
        }

        for (int i = 0; i < numberOfBalls; i++)
        {
            float angle = i * Mathf.PI * 2f / numberOfBalls;
            Vector3 offset = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * circleRadius;
            Vector3 spawnPos = treeTransform.position + offset + Vector3.up * 1f; // 抬高一点

            Instantiate(memoryBallPrefab, spawnPos, Quaternion.identity);
        }
    }

}
