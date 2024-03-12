using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeLevelPage : MonoBehaviour
{
    // Start is called before the first frame update
    bool timer = false;
    float ctimer;
    float stimer = 0.1f;
    public Text timetext;
    
    


    void Start()
    {
        ctimer = stimer * 30;
        timer = true;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (timer == true)
        {
            ctimer = ctimer - Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(ctimer);
       
        timetext.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        

        if (time.Seconds == 0)
        {
            Debug.Log("Time over!!!");
            
            SceneManager.LoadScene(1);
        }
    }
    
}
