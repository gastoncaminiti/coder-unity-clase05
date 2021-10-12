using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EN EL FRAME INICIAL ENEMY...");
        Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(speedEnemy * Vector3.right * Time.deltaTime);
        //transform.position += new Vector3(speedEnemy, 0, 0) * Time.deltaTime;
        //transform.Translate(speedEnemy * Time.deltaTime * Vector3.right);
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.Translate(speedEnemy * Time.deltaTime * Vector3.right);
    }
}
