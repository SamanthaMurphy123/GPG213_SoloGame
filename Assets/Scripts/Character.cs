using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public abstract class Character : MonoBehaviour
{
    [Header("Stats")]
    public int CurHp;
    public int MaxHp;

    [Header("Components")]
    public CharacterController Controller;
    protected Character target;

    public event UnityAction onTakeDamage;

    public void TakeDamage (int damageToTake)
    {
        CurHp -= damageToTake;
        onTakeDamage?.Invoke();

        if(CurHp <= 0 && gameObject.CompareTag("Enemy"))
            Die();

        if (CurHp <= 0 && gameObject.CompareTag("Player"))
            PlayerDie();
    }

    public void PlayerDie()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("DieScene");
    }

    public void Die()
    {
        Destroy(gameObject);
       
    }

    public void SetTarget (Character t)
    {
        target = t;
    }
}