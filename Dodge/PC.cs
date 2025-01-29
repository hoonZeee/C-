using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    private Rigidbody body;
    public float speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {

        body = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
         float xInput = Input.GetAxis("Horizontal");
         float zInput = Input.GetAxis("Vertical");

         float xSpeed = speed * xInput;
         float zSpeed = speed * zInput; 

         body.velocity = new Vector3(xSpeed, 0, zSpeed);
    }

    public void Die(){
        gameObject.SetActive(false);

        GameManager gm  = FindAnyObjectByType<GameManager>();

        if(gm != null){
            gm.EndGame();
        }
    }
}
