using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject selectPlayerMenu;

    public GameObject character1, character2, character3, character4;

    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        ActiveMenu(mainMenu);
        character1.SetActive(true);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HideMenu()
    {
        mainMenu.SetActive(false);
        selectPlayerMenu.SetActive(false);
    }

    public void ActiveMenu(GameObject menu)
    {
        HideMenu();
        menu.SetActive(true);
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

    public void SelectCharacter()
    {
        if(i == 1)
        {
            HideCharacters(character1, character2, character3, character4);
            character1.SetActive(true);
        }
        else if (i == 2)
        {
            HideCharacters(character1, character2, character3, character4);
            character2.SetActive(true);
        }
        else if (i == 3)
        {
            HideCharacters(character1, character2, character3, character4);
            character3.SetActive(true);
        }
        else if (i == 4)
        {
            HideCharacters(character1, character2, character3, character4);
            character4.SetActive(true);
            i = 0;
        }

        i++;

    }

    public void HideCharacters(GameObject character1, GameObject character2, GameObject character3, GameObject character4)
    {
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
    }
}
