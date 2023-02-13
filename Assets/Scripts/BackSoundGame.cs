using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSoundGame : MonoBehaviour
{
    private static BackSoundGame backsoundMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() 
    {
        if(backsoundMusic == null) 
        {
            transform.parent = null;
            backsoundMusic = this;
            DontDestroyOnLoad(backsoundMusic);
        } 
        else 
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
