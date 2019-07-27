using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{

    public Animator Anime;

    // Start is called before the first frame update
    void Start()
    {
        Anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Anime.Play("Another");
    }

    public void OnGazeEnter() {
        Anime.SetBool("See", true);

    }

    public void OnGazeExit()
    {
        Anime.SetBool("See", false);
    }
}
