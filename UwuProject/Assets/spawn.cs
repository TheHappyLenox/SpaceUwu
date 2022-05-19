using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", rate, rate);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Instantiate(enemies[(int)Random.Range(0, enemies.Length)],new Vector3(Random.Range(-35,40),36,0),Quaternion.identity);
    }
}
