using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    #region CLASS_VARIABLES

    public EnemyHealth enemyHealth;

    public int damagePoints = 1;

    #endregion

    #region UNITY_METHODS

    private void Start()
    {
        DealDamage();
    }

    #endregion

    #region CLASS_METHODS

    public void DealDamage()
    {
        enemyHealth.TakeDamage(damagePoints);
    }

    #endregion
}
