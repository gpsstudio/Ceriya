using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInScene : MonoBehaviour
{
    public GameObject fadeIn;

    // Start is called before the first frame update
    void Start()
    {
        fadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
