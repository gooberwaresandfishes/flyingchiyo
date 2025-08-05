using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public LogicScript logic;
    
    public GameObject pipe;
    public GameObject[] items = new GameObject[2];

    private float spawnRate = 5;
    private float spawnTimer = 5;
    private float sataAndagiSpawnTimer = 2.5F;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!logic.isAlive) return;

        spawnTimer += Time.deltaTime;
        sataAndagiSpawnTimer += Time.deltaTime;

        if (spawnTimer > spawnRate)
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-6, 7), 0), transform.rotation);

            spawnTimer = 0;
        }

        if ((sataAndagiSpawnTimer > spawnRate))
        {
            Instantiate(items[Random.Range(0, 2)], new Vector3(transform.position.x, Random.Range(-6, 7), 0), transform.rotation);

            sataAndagiSpawnTimer = 0;
        }

        spawnRate = 5 / ((Time.timeSinceLevelLoad / 30) + 1);
    }
}
