using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool BirdisAlive= true;
    void Start()
    {
      
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdisAlive)
        {
            myrigidbody.velocity = Vector2.up * flapstrength;
        }
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdisAlive=false;
    }
}
