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
    public static PlayerBehavior instance;

    private int i;
    private TypeCharacter type;
    private TypeItem itemType;

    public Text valorComun;
    public Text valorConc;
    public Text valorPrec;
    public Text valorRefle;

    public Text textConcentracao;
    public Text textComunicacao;
    public Text textPrecisao;
    public Text textReflexo;

    public Text storeTextConcentracao;
    public Text storeTextComunicacao;
    public Text storeTextPrecisao;
    public Text storeTextReflexo;

    public GameObject
        idleSprite,
        successSprite,
        failSprite,
        startButton,
        successText,
        failText,
        firstActionText,
        secondActionText,
        thirdActionText,
        popUpPanel;



    private int itemId;

    //private AnimationController animationController;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        currentLevel = PlayerStatsController.GetCurrentLevel();
        type = PlayerStatsController.GetTypeCharacter();
        //animationController = GetComponent<AnimationController>();
        basicStats = PlayerStatsController.instance.GetBasicStats(type);

        valorComun.text = basicStats.comunicacao.ToString();
        valorConc.text = basicStats.concentracao.ToString();
        valorPrec.text = basicStats.precisao.ToString();
        valorRefle.text = basicStats.reflexo.ToString();

        textComunicacao.text = basicStats.comunicacao.ToString();
        textConcentracao.text = basicStats.concentracao.ToString();
        textPrecisao.text = basicStats.precisao.ToString();
        textReflexo.text = basicStats.reflexo.ToString();

        storeTextComunicacao.text = basicStats.comunicacao.ToString();
        storeTextConcentracao.text = basicStats.concentracao.ToString();
        storeTextPrecisao.text = basicStats.precisao.ToString();
        storeTextReflexo.text = basicStats.reflexo.ToString();

        HideGameplayUI();
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


        valorComun.text = basicStats.comunicacao.ToString();
        valorConc.text = basicStats.concentracao.ToString();
        valorPrec.text = basicStats.precisao.ToString();
        valorRefle.text = basicStats.reflexo.ToString();

        textComunicacao.text = basicStats.comunicacao.ToString();
        textConcentracao.text = basicStats.concentracao.ToString();
        textPrecisao.text = basicStats.precisao.ToString();
        textReflexo.text = basicStats.reflexo.ToString();

        storeTextComunicacao.text = basicStats.comunicacao.ToString();
        storeTextConcentracao.text = basicStats.concentracao.ToString();
        storeTextPrecisao.text = basicStats.precisao.ToString();
        storeTextReflexo.text = basicStats.reflexo.ToString();
        TextColorChange();
    }

    public void TextColorChange()
    {
        TextColorReset();

        if (basicStats.comunicacao > 10)
        {
            valorComun.GetComponent<Text>().color = Color.green;
        }
        else if(basicStats.comunicacao < 10)
        {
            valorComun.GetComponent<Text>().color = Color.red;
        }
        if (basicStats.concentracao > 10)
        {
            valorConc.GetComponent<Text>().color = Color.green;
        }
        else if (basicStats.concentracao < 10)
        {
            valorConc.GetComponent<Text>().color = Color.red;
        }
        if (basicStats.precisao > 10)
        {
            valorPrec.GetComponent<Text>().color = Color.green;
        }
        else if (basicStats.precisao < 10)
        {
            valorPrec.GetComponent<Text>().color = Color.red;
        }
        if (basicStats.reflexo > 10)
        {
            valorRefle.GetComponent<Text>().color = Color.green;
        }
        else if (basicStats.reflexo < 10)
        {
            valorRefle.GetComponent<Text>().color = Color.red;
        }
    }

    public void TextColorReset()
    {
        valorComun.GetComponent<Text>().color = Color.white;
        valorConc.GetComponent<Text>().color = Color.white;
        valorPrec.GetComponent<Text>().color = Color.white;
        valorRefle.GetComponent<Text>().color = Color.white;
    }

    public void SetPlayer(int d)
    {
        i = d;
        SetPlayerType(i);
    }


    public void SetPlayerItem(int aux)
    {
        itemId = aux;

        if (aux == 0)
        {
            ItemController.SetItemType(TypeItem.Headset);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.AddValues(basicStatsItem);
        }
        if (aux == 1)
        {
            ItemController.SetItemType(TypeItem.Glasses);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.AddValues(basicStatsItem);
        }
        if (aux == 2)
        {
            ItemController.SetItemType(TypeItem.Mouse);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.AddValues(basicStatsItem);
        }
        if (aux == 3)
        {
            ItemController.SetItemType(TypeItem.Keyboard);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.AddValues(basicStatsItem);
        }
    }

    public void SetPlayerItemType(int d)
    {
        i = d;
        SetPlayerItem(i);
    }

    public void RemovePlayerItem()
    {

        if (itemId == 0)
        {
            ItemController.SetItemType(TypeItem.Headset);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.RemoveValues(basicStatsItem);
        }
        if (itemId == 1)
        {
            ItemController.SetItemType(TypeItem.Glasses);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.RemoveValues(basicStatsItem);
        }
        if (itemId == 2)
        {
            ItemController.SetItemType(TypeItem.Mouse);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.RemoveValues(basicStatsItem);
        }
        if (itemId == 3)
        {
            ItemController.SetItemType(TypeItem.Keyboard);
            itemType = ItemController.GetItemType();
            var basicStatsItem = ItemController.itemController.GetBasicItemStats(itemType);

            basicStats.RemoveValues(basicStatsItem);
        }
    }

    public void PlayerActionTest(int aux)
    {
        HideGameplayUI();

        PlayerStatsController.instance.challengeDifficulty = aux;
        int addStatus = Random.Range(1, 10);

        if(PlayerStatsController.instance.challengeDifficulty == 15)
        {
            if(basicStats.concentracao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.concentracao + addStatus));
                PlayerStatsController.AddXp(100);
                PlayerStatsController.instance.coins += 50;
                HideGameplayUI();
                successSprite.SetActive(true);
                successText.SetActive(true);
            }
            else
            {
                print(addStatus + " " + basicStats.concentracao + addStatus);
                PlayerStatsController.AddXp(10);
                PlayerStatsController.instance.coins += 5;
                HideGameplayUI();
                failSprite.SetActive(true);
                failText.SetActive(true);
            }
        }
        else if(PlayerStatsController.instance.challengeDifficulty == 18)
        {
            if(basicStats.precisao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(100);
                HideGameplayUI();
                successSprite.SetActive(true);
                successText.SetActive(true);
            }
            else
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(10);
                HideGameplayUI();
                failSprite.SetActive(true);
                failText.SetActive(true);
            }
        }


    }

    public void ActiveMenu(GameObject menu)
    {
        HideGameplayUI();
        menu.SetActive(true);
    }

    public void HideGameplayUI()
    {
        successSprite.SetActive(false);
        failSprite.SetActive(false);
        startButton.SetActive(false);
        successText.SetActive(false);
        failText.SetActive(false);
        firstActionText.SetActive(false);
        secondActionText.SetActive(false);
        thirdActionText.SetActive(false);
        popUpPanel.SetActive(false);
    }

}
