using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static AudioButton instance = null;
    [SerializeField] AudioSource Audio;
    
    public static AudioButton Instance
    {
        get { return instance; }
    }

    void Awake() 
    {
        if(instance != null && instance != this) 
        {
            Destroy(this.gameObject);
            return;
        } 
        else 
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void OnAudio() 
    {
        Audio.Play();    
    }

    public void OffAudio() 
    {
        Audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
