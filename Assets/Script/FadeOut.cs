using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
public AnimationClip fadeOutClip;
int indexScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOutLoadScene(int nomorScene)
    {
        gameObject.SetActive(true);
        indexScene = nomorScene;
        Invoke("FadeOutCheck", fadeOutClip.length);

        
    }

    void FadeOutCheck()
    {
        SceneManager.LoadScene(indexScene);
    }
}
