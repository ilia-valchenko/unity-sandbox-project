using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DelayFinchAnimation : MonoBehaviour
{
    //Animator m_Animator;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
        this.animator = GetComponent<Animator>();
        //StartCoroutine();

        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.timeSinceLevelLoad >= 3)
        //{
        //    this.animator.Play("Finch_Walking_Idle_Anim");
        //}
        //else
        //{
        //    this.animator.Play("Stop");  //Here another state
        //}
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        this.animator.Play("Finch_Walking_Idle_Anim");
    }

    //public IEnumerator playAnimation()
    //{
    //    yield return new WaitForSeconds(3f);
    //    this.animator.Play("Finch_Walking_Idle_Anim");
    //    animator.SetTrigger("playerAttack");
    //    // Insert your Play Animations here
    //}
}
