using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishplayer : MonoBehaviour
{
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("w");
            transform.Translate(Vector3.forward * Time.deltaTime * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            print("s");
            transform.Translate(Vector3.forward * Time.deltaTime * -force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("a");
            transform.Translate(Vector3.left * Time.deltaTime * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("d");
            transform.Translate(Vector3.left * Time.deltaTime * -force);
        }
    }
}
