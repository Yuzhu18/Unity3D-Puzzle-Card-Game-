using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class BattleStats 
{
    public static List<CardLogic> PlayerCards = new List<CardLogic>();
    public static List<CardLogic> EnemyCards = new List<CardLogic>();

    public static List<CreatureLogic> PlayerCreatures = new List<CreatureLogic>();
    public static List<CreatureLogic> EnemyCreatures = new List<CreatureLogic>();
}
