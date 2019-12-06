﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float sensitivityMouse = 2f;
    public float sensitivetyMouseWheel = 10f;
    public Transform player1;
    public Transform player2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)//当鼠标滚动时
        {
            this.GetComponent<Camera>().fieldOfView = this.GetComponent<Camera>().fieldOfView - Input.GetAxis("Mouse ScrollWheel") * sensitivetyMouseWheel;
        }
        //按着鼠标右键实现视角转动
        if (Input.GetMouseButton(1))//当鼠标按下时
        {
            float y = Input.GetAxis("Mouse Y");
            float x = Input.GetAxis("Mouse X");
          
            {
                player1.transform.Rotate(-y * sensitivityMouse, x * sensitivityMouse, 0);//鼠标向左右移动（x轴）与向上下移动（y轴）
                player2.transform.Rotate(-y * sensitivityMouse, x * sensitivityMouse, 0);
            }
        }
    }
}
