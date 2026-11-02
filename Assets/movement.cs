using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int hp = 50;
    public GameObject laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(0, -3);
    }

    // Update is called once per frame

    public float speed = 1.0f;
    void Update()
    {

        if (transform.position.x < 9.5 && Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (transform.position.y < 4.5 && Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (transform.position.y > -4.5 && Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (transform.position.x > -9.5 && Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
           if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser,transform.position, Quaternion.identity);
            

        }





        }



    }   
        