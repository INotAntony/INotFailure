using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()
    {
        BattleEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {
    }

    public void GainXP(BattleResultEventData data)
    {
        GameEvents.PlayerXPGain(100);
        GameEvents.PlayerLevelUp(1);
    }
                                    