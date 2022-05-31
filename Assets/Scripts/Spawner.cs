using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public NPC[] npc;
    public float timer;
    public float limit;
    public int cont = 10;

    // Update is called once per frame
    void Update()
    {
        NPC npcr = new NPC();
        NPC npca = new NPC();
        npca.aproach = true;
        timer -= Time.deltaTime;
        if (timer <= 0 && cont >= 0)
        {
            npcr = Instantiate(npc[0], transform.position, transform.rotation);
            timer = limit;
            cont--;
        }
        if (timer <= 0 && cont <= 0)
        {
            npca = Instantiate(npc[1], transform.position, transform.rotation);
            npca.aproach = true;
            timer = limit;
            cont = Random.Range(3, 6);
        }
        /*if (cont < 0)
        {
            npca = Instantiate(npc[1], transform.position, transform.rotation);
            cont = Random.Range(3, 6);
        }*/

        Debug.Log(cont);
    }
}
