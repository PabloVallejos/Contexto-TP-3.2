using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Button[] botones;
    public Text texto;
    public Collider col;
    public Controller cont;
    public MouseLook m;
    private float timer;
    private bool on;

    private void Start()
    {
        botones[0].gameObject.SetActive(false);
        botones[1].gameObject.SetActive(false);
        texto = FindObjectOfType<Text>();
        texto.gameObject.SetActive(false);
        on = true;
        timer = 0;
    }

    private void Update()
    {
        if(on == true)
        {
            col.enabled = true;
        }
        else
        {
            col.enabled = false;
        }

        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            on = false;
        }
        else
        {
            on = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC" || other.gameObject.tag == "Enemy")
        {
            cont.enabled = false;
            m.loc = false;
            botones[0].gameObject.SetActive(true);
            botones[1].gameObject.SetActive(true);
            texto.gameObject.SetActive(true);
        }
        /*botones[0].onClick.AddListener(delegate { GoOn(other); });
        botones[1].onClick.AddListener(delegate { GoOn(other); });*/
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "NPC" || other.gameObject.tag == "Enemy")
        {
            cont.enabled = true;
            m.loc = true;
        }
    }

    /*public void GoOn(Collider other)
    {
        other.GetComponent<NPC>().speed = 5;
        other.GetComponent<NPC>().transform.Rotate(0, -90, 0);
        cont.enabled = true;
        m.loc = true;
        botones[0].gameObject.SetActive(false);
        botones[1].gameObject.SetActive(false);
        timer = 10;
    }*/
}
