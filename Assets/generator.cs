using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{

    public GameObject Quad;
    public int radius = 5;
    public float timer;
    public float timelater = 4f;

 /*   public int counter = 0;
    public int rate = 60; */
    void Start()
    {
        timer = Time.time;


    }

  /*  Vector2 v = Random.insideUnitCircle;
        v = Random.insideUnitCircle;
  */

    void Update()
    {
        Instantiate(Quad, Random.insideUnitCircle * radius, transform.rotation);

        float timeskip = timer + timelater;
        if(Time.time >= timeskip){
            Instantiate(Quad, Random.insideUnitCircle * radius, transform.rotation);
            timer = Time.time;
        }
    }
}
