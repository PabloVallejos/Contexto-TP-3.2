using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeSpace : MonoBehaviour
{
    public ColorTimer time;
    public Nervous nerv;

    private void Start()
    {
        time = FindObjectOfType<ColorTimer>();
        nerv = FindObjectOfType<Nervous>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (time.timer <= time.start && nerv.timer <= nerv.start)
            {
                time.timer++;
                nerv.timer++;
            }
        }
    }
}
