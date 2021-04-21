using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiative : MonoBehaviour
{
    BattleSystem battleSystem;
    

    public void InitiativeRoll()
    {
        int initiativeRollOutcome = (int)(Random.Range(1f, 10f));

        if (initiativeRollOutcome > 0f && initiativeRollOutcome <= 5f)
        {
            //PlayerTurn

        }

        if (initiativeRollOutcome > 5f && initiativeRollOutcome <= 10f)
        {
            //EnemyTurn

        }

        if (initiativeRollOutcome > 10f && initiativeRollOutcome <= 15f)
        {
            //SecondEnemyTurn

        }
    }
}
