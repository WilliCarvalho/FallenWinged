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
   
    public int i;
    public int testSection = 1;
    private int victory;
    private TypeCharacter type;
    private TypeItem itemType;

    public Text valorComun;
    public Text valorConc;
    public Text valorPrec;
    public Text valorRefle;

    public GameObject
        idleSprite,
        successSprite1,
        failSprite1,       
        startButton,
        secondButton,
        thirdButton,
        forthButton,
        successText1,
        failText1,
        successText2,
        failText2,
        successText3,
        failText3,
        successText4,
        failText4,
        successText5,
        failText5,
        successText6,
        failText6,
        successTextMatch,
        failTextMatch,
        firstActionText,
        secondActionText,
        thirdActionText,
        popUpPanel,
        popUpPanel2,
        popUpPanel3;

    public GameObject
        victorySound,
        defeatSound;


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

        //HideGameplayUI();
    }

    // Update is called once per frame
    new void Update()
    {

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
        valorComun.text = basicStats.comunicacao.ToString();
        valorConc.text = basicStats.concentracao.ToString();
        valorPrec.text = basicStats.precisao.ToString();
        valorRefle.text = basicStats.reflexo.ToString();

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
                //PlayerStatsController.instance.coins += 50;
                HideGameplayUI();
                successSprite1.SetActive(true);
                successText1.SetActive(true);
                victory++;
                victorySound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
            else
            {
                print(addStatus + " " + basicStats.concentracao + addStatus);
                PlayerStatsController.AddXp(50);
                //PlayerStatsController.instance.coins += 5;
                HideGameplayUI();
                failSprite1.SetActive(true);
                failText1.SetActive(true);
                defeatSound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
        }
        else if (PlayerStatsController.instance.challengeDifficulty == 16)
        {
            if (basicStats.precisao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(100);
                HideGameplayUI();
                successSprite1.SetActive(true);
                successText3.SetActive(true);
                victory++;
                victorySound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
            else
            {
                print(addStatus + " " + (basicStats.precisao + addStatus));
                PlayerStatsController.AddXp(50);
                HideGameplayUI();
                failSprite1.SetActive(true);
                failText3.SetActive(true);
                defeatSound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
        }
        else if (PlayerStatsController.instance.challengeDifficulty == 17)
        {
            if (basicStats.comunicacao + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.comunicacao + addStatus));
                PlayerStatsController.AddXp(100);
                HideGameplayUI();
                successSprite1.SetActive(true);
                successText4.SetActive(true);
                victory++;
                victorySound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
            else
            {
                print(addStatus + " " + (basicStats.comunicacao + addStatus));
                PlayerStatsController.AddXp(50);
                HideGameplayUI();
                failSprite1.SetActive(true);
                failText4.SetActive(true);
                defeatSound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
        }
        else if(PlayerStatsController.instance.challengeDifficulty == 18)
        {
            if(basicStats.reflexo + addStatus >= PlayerStatsController.instance.challengeDifficulty)
            {
                print(addStatus + " " + (basicStats.reflexo + addStatus));
                PlayerStatsController.AddXp(100);
                HideGameplayUI();
                successSprite1.SetActive(true);
                successText2.SetActive(true);
                victory++;
                victorySound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
            else
            {
                print(addStatus + " " + (basicStats.reflexo + addStatus));
                PlayerStatsController.AddXp(50);
                HideGameplayUI();
                failSprite1.SetActive(true);
                failText2.SetActive(true);
                defeatSound.GetComponent<AudioSource>().Play();
                StartCoroutine(ChangeText());
            }
        }


    }

    IEnumerator ChangeText()
    {
        yield return new WaitForSeconds(3.0f);
        HideButton();
        HideGameplayUI();
        idleSprite.SetActive(true);

        if (testSection == 1)
        {
            secondButton.SetActive(true);
            testSection++;
        }
        else if(testSection == 2)
        {
            thirdButton.SetActive(true);
            testSection++;
        }
        else if(testSection == 3)
        {
            if(victory >= 2)
            {
                HideGameplayUI();
                successSprite1.SetActive(true);
                successTextMatch.SetActive(true);
                victorySound.GetComponent<AudioSource>().Play();
                PlayerStatsController.AddXp(500);
                PlayerStatsController.instance.coins += 1000;
            }
            else
            {
                HideGameplayUI();
                failSprite1.SetActive(true);
                failTextMatch.SetActive(true);
                defeatSound.GetComponent<AudioSource>().Play();
                PlayerStatsController.AddXp(250);
                PlayerStatsController.instance.coins += 500;
            }            
            testSection++;
            StartCoroutine(ChangeText());
        }
        else if (testSection == 4)
        {
            HideGameplayUI();            
            idleSprite.SetActive(true);
            forthButton.SetActive(true);
            testSection++;
        }
        print(testSection);
        
    }

    public void HideButton()
    {
        startButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
    }

    public void ActiveMenu(GameObject menu)
    {
        HideGameplayUI();
        idleSprite.SetActive(true);
        menu.SetActive(true);
    }

    public void HideGameplayUI()
    {
        successSprite1.SetActive(false);
        failSprite1.SetActive(false);        
        startButton.SetActive(false);
        secondButton.SetActive(false);
        thirdButton.SetActive(false);
        successText1.SetActive(false);
        failText1.SetActive(false);
        successText2.SetActive(false);
        failText2.SetActive(false);
        successText3.SetActive(false);
        failText3.SetActive(false);
        successText4.SetActive(false);
        failText4.SetActive(false);
        successText5.SetActive(false);
        failText5.SetActive(false);
        successText6.SetActive(false);
        failText6.SetActive(false);
        successTextMatch.SetActive(false);
        failTextMatch.SetActive(false);
        popUpPanel.SetActive(false);
        popUpPanel2.SetActive(false);
        popUpPanel3.SetActive(false);
        idleSprite.SetActive(false);
    }

}
