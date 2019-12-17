using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStateBehavior : StateMachineBehaviour
{
    public FighterStates behaviorState;
    public AudioClip soundEffect;

    public float horizontalForce;
    public float verticalForce;

    protected Fighter fighter;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {
        if (fighter == null)
        {
            fighter = animator.gameObject.GetComponent<Fighter>();
        }

        fighter.currentState = behaviorState;

        fighter.body.AddRelativeForce(new Vector3(0, verticalForce, 0));
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {
        fighter.body.AddRelativeForce(new Vector3(0, 0, horizontalForce));
    }
}
