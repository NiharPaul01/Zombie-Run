using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetObj;
    public float rotationSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 2 * Time.deltaTime);
        Vector3 direction = targetObj.position - transform.position;
        direction = direction.normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

    }
}
