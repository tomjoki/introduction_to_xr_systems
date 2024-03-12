using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    public float speed;
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gCurrent;
    private float tCurrent;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if (gCurrent != gripTarget)
        {
            gCurrent = Mathf.MoveTowards(gCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat("Grip", gCurrent);
        }
        if (tCurrent != triggerTarget)
        {
            tCurrent = Mathf.MoveTowards(tCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat("Trigger", gCurrent);
        }
    }
}
