using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotation;
    public float jumpForce;

    Rigidbody rb;

    public ParticleSystem Jump;
    public ParticleSystem StarP;

    //public GameObject GreenScore;

    //public float Spawntime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //InvokeRepeating("SpawnCube", Spawntime, Spawntime);
        //Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        //Instantiate(GreenScore, position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {

        float verticalinput = Input.GetAxis("Vertical");
        float horizontalinput = Input.GetAxis("Horizontal");



        float vVelocity = 0;



        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(-Vector3.up * rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {


            transform.Rotate(Vector3.up * rotation * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            vVelocity = jumpForce;

            Jump.Play();
        }
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Ouch");

            StarP.Play();
        }
        
       // if (collision.gameObject.tag == "Goal")
        //{
            //Debug.Log("Touch");

            //(collision.gameObject);
            //SpawnCube();
            
        //}
        
    }
   

    //void SpawnCube()
    //{
       //Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        //Instantiate(GreenScore, position, Quaternion.identity);
    //}
    



}
