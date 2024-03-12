using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelCount : MonoBehaviour
{
    public Text timtext;
    int countFromStatic = SceneLoaderTracker.scene2LoadCount;
    
    // Start is called before the first frame update
    void Start()
    {
        ++countFromStatic;
    }

    // Update is called once per frame
    void Update()
    {
        timtext.text = "Level : " + countFromStatic;
    }
}
