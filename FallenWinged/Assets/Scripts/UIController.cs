using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Text coins;
    public Text xp;
    public Text level;
    public Text nextLevel;

    public static Text situationText;
    public static Text situarionText2;

    public int textActive;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        coins.text = PlayerStatsController.instance.coins.ToString();
        xp.text = PlayerStatsController.GetCurrentXp().ToString();
        level.text = PlayerStatsController.GetCurrentLevel().ToString();
        nextLevel.text = PlayerStatsController.GetNextXp().ToString();

        if(textActive == 1)
        {
            StartCoroutine(UIController.ChangeButtonText(1));
        }
        else if (textActive == 2)
        {
            StartCoroutine(UIController.ChangeButtonText(2));
        }

    }

    public static IEnumerator ChangeButtonText(int aux)
    {
        yield return new WaitForSeconds(1.5f);
        if(aux == 1)
        {

            situationText.enabled = true;
        }
        else if (aux == 2)
        {
            situarionText2.enabled = true;
        }
    }

    public void OpenURLHeadset()
    {
        StartCoroutine(WaitOpenURL());
    }

    IEnumerator WaitOpenURL()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("https://www.fallenstore.com.br/categoria/headsets");
    }
    public void OpenURLGlasses()
    {
        StartCoroutine(WaitOpenURL2());
    }

    IEnumerator WaitOpenURL2()
    {
        yield return new WaitForSeconds(1.0f);
        Application.OpenURL("https://www.fallenstore.com.br/busca?s=oculos");
    }
}
