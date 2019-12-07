using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creat : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
           GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);//生成立方体
            obj.transform.position = new Vector3(Random.Range(-15,15), Random.Range(-20, 2), Random.Range(-25, 2));//随机设置立方体位置
            obj.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
    
    private void FixedUpdate()
    {
        for (int j=0; j < 5;j++)
        {
           GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = new Vector3(Random.Range(-25, 15), Random.Range(-25, 4), Random.Range(-40,15));
            obj.GetComponent<Renderer>().material.color = Color.black;
            j++;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    public Transform player;
    void Update()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        float dis= Vector3.Distance(obj.transform.position,player.transform.position);
        if (dis < 0.1)
            Destroy(obj, dis);
    }
}

