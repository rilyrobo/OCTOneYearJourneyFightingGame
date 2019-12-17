using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinStateBehavior : FighterStateBehavior
{
    override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        float fighterX = fighter.transform.position.x;
        float fighterZ = fighter.transform.position.z;

        GameObject instance = Object.Instantiate
            (
            Resources.Load("Coin"),
            new Vector3 (fighterX+1, 1, fighterZ),
            Quaternion.Euler (0, 0, 0)
            ) as GameObject;

        Coin coin = instance.GetComponent<Coin>();
        coin.caster = fighter;
    }
}
