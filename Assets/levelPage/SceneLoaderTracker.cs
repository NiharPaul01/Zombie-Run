using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderTracker : MonoBehaviour
{
    public static int scene2LoadCount = 0;
    private static SceneLoaderTracker _instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
       
        
    }
     private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.buildIndex == 1)
        {
            scene2LoadCount++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
