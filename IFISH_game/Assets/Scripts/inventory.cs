using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory
{
    
    void Start()
    {
        initInventory();
    }
    
    
    public List<fishObject> fish = new List<fishObject>();


    private void initInventory()
    {
        fish.Add(new fishObject(001, "testFish", "a fish", 1, makeSpread(0.16f, 0.16f, 0.16f, 0.16f, 0.16f, 0.16f)));
    }


    private Dictionary<string, float> makeSpread(float hp, float attack, float defense, float magic, float speed, float mana)
    {
        Dictionary<string, float> spread = new Dictionary<string, float>();
        spread.Add("hp", hp);
        spread.Add("attack", attack);
        spread.Add("defense", defense);
        spread.Add("magic", magic);
        spread.Add("speed", speed);
        spread.Add("mana", mana);
        return spread;
    }


}
