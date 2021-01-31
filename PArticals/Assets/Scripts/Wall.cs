using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Transform Walls;
    public int numTospawn;
    int spawned = 0;




    // Start is called before the first frame update
    public Vector3 position;
    void Start()
    {
     
        
    //int spawned = 0;

        while(spawned < numTospawn)
        {
           position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
           Instantiate(Walls, position, Quaternion.identity);
            spawned++;
        }
    }
   
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
