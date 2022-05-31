using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nervous : MonoBehaviour
{
    public ColorTimer Ctime;
    public Image img;
    public AudioSource heart;
    public string scene;
    public float timer;
    public float start;
    private Color32 temp;
    private float fadeTime = 40;
    private bool fade;

    private void Start()
    {
        img.canvasRenderer.SetAlpha(0);
        heart.mute = true;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= start / 1.4f)
        {
            img.CrossFadeAlpha(1, fadeTime, false);
        }
        if (timer <= start / 2)
        {
            heart.mute = false;
        }
        if (timer >= start)
        {
            img.CrossFadeAlpha(0, 0f, false);
            heart.mute = true;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
