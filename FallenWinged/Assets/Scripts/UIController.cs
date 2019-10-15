using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text coins;
    public Text xp;
    public Text level;
    public Text nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = PlayerStatsController.instance.coins.ToString();
        xp.text = PlayerStatsController.GetCurrentXp().ToString();
        level.text = PlayerStatsController.GetCurrentLevel().ToString();
        nextLevel.text = PlayerStatsController.GetNextXp().ToString();
    }
}
