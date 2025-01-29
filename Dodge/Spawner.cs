using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bullet;
    public float SpawnRateMin = 0.5f;
    public float SpawnRateMax = 3.0f;

    private Transform target;

    private float gentime;
    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        gentime = Random.Range(SpawnRateMin, SpawnRateMax);

        target = FindAnyObjectByType<PC>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= gentime){

            timeAfterSpawn = 0f;

            GameObject bt = Instantiate(bullet, transform.position, transform.rotation);

            bt.transform.LookAt(target);

            gentime = Random.Range(SpawnRateMin, SpawnRateMax);
        }
        
    }
}
