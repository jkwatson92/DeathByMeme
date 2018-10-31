using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MothAI : MonoBehaviour {
    public Transform[] EnemyPoints;
    Transform currentPoint;
    int currentPointIndex;

    // Use this for initialization
    void Start()
    {
        currentPointIndex = 0;
        currentPoint = EnemyPoints[currentPointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10f);
        if(Vector3.Distance(transform.position, currentPoint.position)<.1f){
            if (currentPointIndex + 1 < EnemyPoints.Length)
            {
                currentPointIndex++;
            } else {
                currentPointIndex = 0;
            }
            currentPoint = EnemyPoints[currentPointIndex];
        }
        Vector3 direction = currentPoint.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);

    }

}
