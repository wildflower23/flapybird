using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpwanscript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    void Start()
    {
        spwanpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanpipe();
            timer = 0;
        }

    }
    void spwanpipe()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);

    }
}
