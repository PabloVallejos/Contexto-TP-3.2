using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    public ColorTimer time;
    public Color32 colorStart;
    public Color32 colorEnd;
    public Color32 current;
    public float duration;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
        time = FindObjectOfType<ColorTimer>();
    }

    void Update()
    {
        /*float lerp = Mathf.PingPong(Time.time, duration) / duration;
        current = Color32.Lerp(colorStart, colorEnd, lerp);*/
        current = time.Ccolor;
        rend.material.color = current;
    }
}
