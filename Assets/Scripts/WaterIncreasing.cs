using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterIncreasing : MonoBehaviour

{
    public float speed =5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, 200), transform.position.z);
    }
}
