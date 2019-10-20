using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject selectPlayerMenu;

    public GameObject
        character1,
        character2,
        character3,
        character4,
        equipmentselection,
        mentordialogue1,
        mentordialogue2,
        championshipscreen,
        rankedpanel,
        regionalpanel,
        nacionapanel,
        mundialpanel,
        store, stats,
        gameplay,
        statusDisplayValues;

    public GameObject
        valorComun,
        valorConc,
        valorPrec,
        valorRefle;



    //public int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        ActiveMenu(mainMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HideMenu()
    {
        mainMenu.SetActive(false);
        selectPlayerMenu.SetActive(false);
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
        equipmentselection.SetActive(false);
        mentordialogue1.SetActive(false);
        mentordialogue2.SetActive(false);
        championshipscreen.SetActive(false);
        rankedpanel.SetActive(false);
        regionalpanel.SetActive(false);
        nacionapanel.SetActive(false);
        mundialpanel.SetActive(false);
        store.SetActive(false);
        stats.SetActive(false);
        gameplay.SetActive(false);
        statusDisplayValues.SetActive(false);

        valorComun.GetComponent<Text>().color = Color.white;
        valorConc.GetComponent<Text>().color = Color.white;
        valorPrec.GetComponent<Text>().color = Color.white;
        valorRefle.GetComponent<Text>().color = Color.white;
    }

    public void ActiveMenu(GameObject menu)
    {
        HideMenu();
        menu.SetActive(true);

        if (menu.tag == "CharacterSelect")
        {
            statusDisplayValues.SetActive(true);
        }
    }

    //activate the exit method in ApplicationController
    public void ExitGame()
    {
        ApplicationController.ExitGame();
    }

    public void Play()
    {
        Application.LoadLevel("Gameplay");
    }

    //public void selectcharacter()
    //{
    //    if(i == 1)
    //    {
    //        hidecharacters(character1, character2, character3, character4);
    //        character1.setactive(true);
    //    }
    //    else if (i == 2)
    //    {
    //        hidecharacters(character1, character2, character3, character4);
    //        character2.setactive(true);
    //    }
    //    else if (i == 3)
    //    {
    //        hidecharacters(character1, character2, character3, character4);
    //        character3.setactive(true);
    //    }
    //    else if (i == 4)
    //    {
    //        hidecharacters(character1, character2, character3, character4);
    //        character4.setactive(true);
    //        i = 0;
    //    }

    //    i++;

    //}

    public void HideCharacters(GameObject character1, GameObject character2, GameObject character3, GameObject character4)
    {
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
    }
}
