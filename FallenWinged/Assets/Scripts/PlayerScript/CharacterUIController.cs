using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUIController : MonoBehaviour
{
    public Text concentrationValue;
    public Text comunicationValue;
    public Text precisionValue;
    public Text reflexValue;

    public GameObject buttonAddConcentration;
    public GameObject buttonAddComunication;
    public GameObject buttonAddPrecision;
    public GameObject buttonAddReflex;

    public Text remainingPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowButtons()
    {
        bool hasToShowButton = PlayerStatsController.GetAttributsPoints() > 0;

        buttonAddConcentration.SetActive(hasToShowButton);
        buttonAddComunication.SetActive(hasToShowButton);
        buttonAddPrecision.SetActive(hasToShowButton);
        buttonAddReflex.SetActive(hasToShowButton);
    }
    
    // Update is called once per frame
    void Update()
    {
        ShowButtons();
        remainingPoints.text = PlayerStatsController.GetAttributsPoints().ToString();
    }

    public void AddAttribute(string attributeName)
    {
        PlayerStatsController.AddAttribute(attributeName, 1);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public bool HasWindowOpen()
    {
        return false;
    }
}
