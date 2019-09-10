using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasicStats
{
    //Basics atributes
    public int concentracao;
    public int comunicacao;
    public int precisao;
    public int reflexo;

    public void AddValues(BasicStats baseStatsToadd)
    {
        concentracao += baseStatsToadd.concentracao;
        comunicacao += baseStatsToadd.comunicacao;
        precisao += baseStatsToadd.precisao;
        reflexo += baseStatsToadd.reflexo;
    }

    public void RemoveValues(BasicStats baseStatsToadd)
    {
        concentracao -= baseStatsToadd.concentracao;
        comunicacao -= baseStatsToadd.comunicacao;
        precisao -= baseStatsToadd.precisao;
        reflexo -= baseStatsToadd.reflexo;
    }
}

public abstract class CharacterBase : MonoBehaviour
{
    public int currentLevel;
    public BasicStats basicStats;

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {

    }

   
}
