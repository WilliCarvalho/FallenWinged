using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TypeCharacter
{
    Achiever = 0,
    Social = 1,
    Killer = 2,
    Explorer = 3
}

public class PlayerBehavior : CharacterBase
{
    private int i;
    private TypeCharacter type;
    private TypeItem itemType;

    public Text ValorComun;
    public Text ValorConc;
    public Text ValorPrec;
    public Text ValorRefle;

    //private AnimationController animationController;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        type = PlayerStatsController.GetTypeCharacter();
        //animationController = GetComponent<AnimationController>();
        basicStats = PlayerStatsController.instance.GetBasicStats(type);

        ValorComun.text = basicStats.comunicacao.ToString();
        ValorConc.text = basicStats.concentracao.ToString();
        ValorPrec.text = basicStats.precisao.ToString();
        ValorRefle.text = basicStats.reflexo.ToString();
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


    //perguntar pro rodrigo como fazer escolha da classe do player por 1 método só
    public void SetPlayerType(int aux)
    {
        if (aux == 0)
        {
            PlayerStatsController.SetTyperCharacter(TypeCharacter.Achiever);
            type = PlayerStatsController.GetTypeCharacter();
            basicStats = PlayerStatsController.instance.GetBasicStats(type);
        }
        else if (aux == 1)
        {
            PlayerStatsController.SetTyperCharacter(TypeCharacter.Social);
            type = PlayerStatsController.GetTypeCharacter();
            basicStats = PlayerStatsController.instance.GetBasicStats(type);
        }
        else if (aux == 2)
        {
            PlayerStatsController.SetTyperCharacter(TypeCharacter.Killer);
            type = PlayerStatsController.GetTypeCharacter();
            basicStats = PlayerStatsController.instance.GetBasicStats(type);
        }
        else if (aux == 3)
        {
            PlayerStatsController.SetTyperCharacter(TypeCharacter.Explorer);
            type = PlayerStatsController.GetTypeCharacter();
            basicStats = PlayerStatsController.instance.GetBasicStats(type);
        }
    }

    public void SetPlayer(int d)
    {
        i = d;
        SetPlayerType(i);
    }


    public void SetPlayerItem(int aux)
    {

        if (aux == 0)
        {
            ItemController.SetItemType(TypeItem.Headset);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            print(basicStats.comunicacao);

            basicStats.AddValues(basicStatsItem);

            print(basicStats.comunicacao);
        }
        if (aux == 1)
        {
            ItemController.SetItemType(TypeItem.Glasses);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            print(basicStats.concentracao);

            basicStats.AddValues(basicStatsItem);

            print(basicStats.concentracao);
        }
        if (aux == 2)
        {
            ItemController.SetItemType(TypeItem.Mouse);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            print(basicStats.precisao);

            basicStats.AddValues(basicStatsItem);

            print(basicStats.precisao);
        }
        if (aux == 3)
        {
            ItemController.SetItemType(TypeItem.Keyboard);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            print(basicStats.reflexo);

            basicStats.AddValues(basicStatsItem);

            print(basicStats.reflexo);
        }
    }

    public void SetPlayerItemType(int d)
    {
        i = d;
        SetPlayerItem(i);
    }

    public void PlayerActionTest(int aux)
    {
        PlayerStatsController.instance.challengeDifficulty = aux;
        int addStatus = Random.Range(1, 10);

        if(PlayerStatsController.instance.challengeDifficulty == 15)
        {
            if(basicStats.concentracao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.concentracao + addStatus));
                PlayerStatsController.AddXp(100);
                PlayerStatsController.instance.coins += 50;
            }
            else
            {
                print(addStatus + " " + basicStats.concentracao + addStatus);
                PlayerStatsController.AddXp(10);
                PlayerStatsController.instance.coins += 5;
            }
        }
        else if(PlayerStatsController.instance.challengeDifficulty == 18)
        {
            if(basicStats.precisao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(200);
            }
            else
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(20);
            }
        }


    }

}
