using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe_Code : MonoBehaviour
{
    public GameObject scrollbar;
    float scrool_pos = 0;
    float [] pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos [i] = distance * i;
        }
        if (Input.GetMouseButton(0))
        {
            scrool_pos = scrollbar.GetComponent<Scrollbar> ().value;
        }else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if(scrool_pos < pos[i] + (distance/2) && scrool_pos > pos[i] - (distance/2)){
                    scrollbar.GetComponent<Scrollbar> ().value = Mathf.Lerp (scrollbar.GetComponent<Scrollbar> ().value, pos[i], 0.1f);
                }
            }
        }

        for (int i = 0; i < pos.Length; i++)
            {
                if(scrool_pos < pos[i] + (distance/2) && scrool_pos > pos[i] - (distance/2)){
                    transform.GetChild(i).localScale = Vector2.Lerp (transform.GetChild(i).localScale, new Vector2(2.9f, 2.9f),0.1f);
                    for (int a = 0; a < pos.Length; a++){
                        if (a != i){
                            transform.GetChild (a).localScale = Vector2.Lerp (transform.GetChild (a).localScale, new Vector2(2.6f,2.6f), 0.1f);
                        }

                    }
                }
            }
    }
}
