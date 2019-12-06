using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickBack : MonoBehaviour
{
    public void Click_Back()
    { 
            SceneManager.LoadScene(1);
    }
    public void OnExitButtonClick()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
