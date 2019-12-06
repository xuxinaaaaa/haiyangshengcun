using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    private Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "driver")
        { StartCoroutine(GameOver(1f));

        }
    }
    
        IEnumerator GameOver(float t)
        {
            //停顿t秒执行下面语句
            yield return new WaitForSeconds(t);
        SceneManager.LoadScene(2);

    }
   

    // Update is called once per frame
    void Update()
    {
       
    }
}
