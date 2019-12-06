using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rd;
    public GameObject target;   //要到达的目标  
    public float speed = 10;    //速度  
    private float distanceToTarget;   //两者之间的距离  
     private bool Move = true;
    // Start is called before the first frame update
    void Start()
    {//计算两者之间的距离  
        distanceToTarget = Vector3.Distance(this.transform.position, target.transform.position);
        StartCoroutine(StartShoot());
        rd = GetComponent<Rigidbody>();
    }
    IEnumerator StartShoot()
   {  
   
         while (Move)  
         {  
             Vector3 targetPos = target.transform.position;  
   
             //让始终它朝着目标  
            this.transform.LookAt(targetPos);  
  
            //计算弧线中的夹角  
            float angle = Mathf.Min(1, Vector3.Distance(this.transform.position, targetPos) / distanceToTarget) * 45;  
            this.transform.rotation = this.transform.rotation* Quaternion.Euler(Mathf.Clamp(angle, -42, 42), 0, 0);  
            float currentDist = Vector3.Distance(this.transform.position, target.transform.position);  
             if (currentDist< 0.5f)  
                 Move = false;  
             this.transform.Translate(Vector3.forward* Mathf.Min(speed* Time.deltaTime, currentDist));  
             yield return null;  
         }  
     }  
    // Update is called once per frame
    void Update()
    {
       


    }




}
