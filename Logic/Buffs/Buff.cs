using UnityEngine;
using System.Collections;

[System.Serializable]
public class BuffInfo
{
    public string BuffClassName;
    public int buffHealth;
    public int buffAttack;
    public int buffManaCost;
    // for example: how many cards to draw, for how many points to heal?
    public int buffSpecialAmount;
}


// this script will be attached to a creature or SPELL and 
// a) affect his stats
// b) give him some new powers
// c) create a spell effect
[System.Serializable]
public class Buff
{
    public int buffHealth;
    public int buffAttack;
    public int buffManaCost;
    // for example: how many cards to draw, for how many points to heal?
    public int buffSpecialAmount;

    public void SetValuesFromBuffInfo(BuffInfo bi)
    {
        buffAttack = bi.buffAttack;
        buffHealth = bi.buffHealth;
        buffManaCost = bi.buffManaCost;
        buffSpecialAmount = bi.buffSpecialAmount;
    }

    public virtual void BuffAction()
    {
        
    }

    public virtual void AttachBuffToEvent()
    {
        
    }

}
