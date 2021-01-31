using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWall : MonoBehaviour
{
    public GameObject Walls;
    public float spawnInterval;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    int Prefadslimit = 5;
    int Prefadscount = 0;

    public float Spawntime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitandSpawn(spawnInterval));


        InvokeRepeating("WaitandSpawn", Spawntime, Spawntime);

    }
    private IEnumerator WaitandSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));

            Instantiate(Walls, spawnPosition, Quaternion.identity);

            Prefadscount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Prefadscount > 10)
        { 
        CancelInvoke("WaitandSpawn");
    }
    }


    

}
