using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 8.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag =="Player"){
            PC pc = other.GetComponent<PC>();

            if(pc != null){
                pc.Die();
            }
        }
        
    }
   
}
