using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject ZombiePrefab;
    [SerializeField] private Transform targetTransform;

    private float ZombieInterval = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(ZombieInterval, ZombiePrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, GetRandomPositionAroundTransform(transform, 5f, 3f), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, newEnemy));
    }

    private Vector3 GetRandomPositionAroundTransform(Transform targetTransform, float radius, float yOffset)
    {
        Vector3 targetPosition = targetTransform.position;
        targetPosition.y += yOffset;
        Vector2 randomOffsetXZ = Random.insideUnitSphere * radius;
        Vector3 randomOffset = new Vector3(randomOffsetXZ.x, yOffset, randomOffsetXZ.y);
        return targetPosition + randomOffset;
    }
}
