using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorAkhir : MonoBehaviour
{
    public Text skorakhirText;
    public Text skorxText;

    int skorakhir = 0;
    int skorx = 0;
    // Start is called before the first frame update
    void Start()
    {
        skorakhir = PlayerPrefs.GetInt("skorakhir", 0);
        skorxText.text = skorx.ToString()+"Skor ";
        skorakhirText.text = "Skor Akhir";
        // PlayerPrefs.SetInt("skor", skor);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("skorakhir", skorx);
        GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();
    }
}
