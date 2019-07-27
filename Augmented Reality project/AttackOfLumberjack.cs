using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOfLumberjack : MonoBehaviour
{
    public Transform Annie;
    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Annie);
        Vector3 direction = Annie.transform.position - this.transform.position;
        if (Vector3.Distance(Annie.position,this.transform.position)<25)
        {
            anim.Play("Lumbering");
        }
    }
}