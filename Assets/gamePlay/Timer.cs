using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    // Start is called before the first frame update
    bool tim = false;
    float ctime;
    float stime = 0.3f;
    public Text timtext;
    int countFromStatic = SceneLoaderTracker.scene2LoadCount;
    void Start()
    {
        ctime = stime * (60 + (countFromStatic *100));
        tim = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (tim == true)
        {
            ctime = ctime - Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(ctime);
        timtext.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

        if (time.Seconds == 0)
        {
            Debug.Log("Time over!!!");
            SceneManager.LoadScene(2);
        }
    }
}
