using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCharacter
{
    Achiever = 0,
    Palestrinha = 1,
    Killer = 2,
    Explorer = 3
}

public class PlayerBehavior : CharacterBase
{
    private TypeCharacter type;

    //private AnimationController animationController;

    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        type = PlayerStatsController.GetTypeCharacter();
        //animationController = GetComponent<AnimationController>();
        basicStats = PlayerStatsController.instance.GetBasicStats(type);
    }

    // Update is called once per frame
    new void Update()
    {
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    //print("estou andando");
        //    animationController.PlayAnimation(AnimationStates.WALKING);
        //    // print("continuo andando");
        //}
        //else if (Input.GetKeyDown(KeyCode.V))
        //{
        //    animationController.PlayAnimation(AnimationStates.RUNNING);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    animationController.PlayAnimation(AnimationStates.IDLE);
        //}
    }
}
