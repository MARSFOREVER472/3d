using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    #region CLASS_VARIABLES

    public int lifePoints = 10;

    #endregion

    #region CLASS_METHODS

    public void TakeDamage(int damagePoints)
    {
        lifePoints = lifePoints - damagePoints;
    }

    #endregion
}
