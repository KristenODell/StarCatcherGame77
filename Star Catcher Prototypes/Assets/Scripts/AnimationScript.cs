using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour
{
    public Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int idleHash = Animator.StringToHash("Idle");
    int runHash = Animator.StringToHash("Run");


	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	

	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(jumpHash);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger(runHash);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger(runHash);
        }
        if (Input.anyKey == false)
        {
            anim.SetTrigger(idleHash);
        }
    }
}
