using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorX : MonoBehaviour
{
    int skor;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("skor", skor);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();
    }
}
