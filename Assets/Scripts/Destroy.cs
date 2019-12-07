using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Transform m_transform;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();
 }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { m_transform.Translate(Vector3.left * 5 * Time.deltaTime); }
        if (Input.GetKey(KeyCode.D)) { m_transform.Translate(Vector3.right * 5 * Time.deltaTime); }
        if (Input.GetKey(KeyCode.W)) { m_transform.Translate(Vector3.forward * 5 * Time.deltaTime); }
        if (Input.GetKey(KeyCode.S)) { m_transform.Translate(Vector3.back * 5 * Time.deltaTime); }

    }
    void OnCollisionEnter(Collision other) 
    { 
        if (other.gameObject.name == "Cube")
        { Debug.Log("销毁" + other.gameObject.name);
            Destroy(other.gameObject); 
        }
    }

}
