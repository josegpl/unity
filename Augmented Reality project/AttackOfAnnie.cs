using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOfAnnie : MonoBehaviour
{
    public Transform Lumberjack;
    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Lumberjack);
        Vector3 direction = Lumberjack.transform.position - this.transform.position;
        if(Vector3.Distance(Lumberjack.position,this.transform.position)<25)
        {
            anim.Play("WAIT04");
        }
    }
}
