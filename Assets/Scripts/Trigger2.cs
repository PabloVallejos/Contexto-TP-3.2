using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger2 : MonoBehaviour
{
    public NPC npc;
    public Button[] boton;
    public Text texto;

    private void Start()
    {
        texto = FindObjectOfType<Text>(true);
    }

    private void Update()
    {
        boton = FindObjectsOfType<Button>(true);
        boton[0].onClick.AddListener(GoOn);
        boton[1].onClick.AddListener(GoOn);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            npc.speed = 0;
        }
    }

    public void GoOn()
    {
        npc.speed = 5;
        npc.transform.Rotate(0, 90, 0);
        boton[0].gameObject.SetActive(false);
        boton[1].gameObject.SetActive(false);
        texto.gameObject.SetActive(false);
        Destroy(this);
    }
}
