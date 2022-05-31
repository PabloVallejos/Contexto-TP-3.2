using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTimer : MonoBehaviour
{
    public float timer;
    public float limiter;
    public int start;
    public int end;
    public Color32 Ccolor;
    private Color32 Scolor = new Color32(0, 0, 255, 100);
    private Color32 Ecolor = new Color32(255, 0, 0, 100);
    private float lerp;
    private float Ctime;

    private void Start()
    {
        timer = start;
        Ccolor = Scolor;
    }

    void Update()
    {
        if (timer >= end)
        {
            timer -= Time.deltaTime;
            Ctime += Time.deltaTime / limiter;
            lerp = Mathf.PingPong(Ctime, start) / start;
            Ccolor = Color32.Lerp(Scolor, Ecolor, Ctime);
        }
        if (timer >= start)
        {
            Ccolor = Scolor;
            Ctime = 0;
        }
    }
}
