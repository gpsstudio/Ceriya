using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void jawaban(bool jawab) 
    {
        if(jawab) {
            int skor = PlayerPrefs.GetInt("skor")+10;
            PlayerPrefs.SetInt("skor", skor);
            int jb = PlayerPrefs.GetInt("jb")+1;
            PlayerPrefs.SetInt("jb", jb);
        } else {
            int js = PlayerPrefs.GetInt("js")+1;
            PlayerPrefs.SetInt("js", js);
        }

        int nosoal = PlayerPrefs.GetInt("nosoal")+1;
        PlayerPrefs.SetInt("nosoal", nosoal);
        if(nosoal >= 10) {
            nosoal = 10;
            PlayerPrefs.SetInt("nosoal", nosoal);
        }

        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
