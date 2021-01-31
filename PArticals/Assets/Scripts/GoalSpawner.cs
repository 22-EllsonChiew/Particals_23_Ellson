using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawner : MonoBehaviour
{

    public GameObject GreenScore;

    public float Spawntime = 3f;




    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnCube", Spawntime);
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(GreenScore, position, Quaternion.identity);
    }
    void SpawnCube()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(GreenScore, position, Quaternion.identity);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Touch");

            Destroy(collision.gameObject);
            SpawnCube();
            Destroy(collision.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    

}
