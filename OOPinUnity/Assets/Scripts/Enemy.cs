/*
 * Levi Wyant
 * Assignment 6
 * Enemy AI scripts
 */


using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, Idamageable
{ 
    private float speed;
    protected int health;


    [SerializeField] protected Weapon weapon;
    // Start is called before the first frame update

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5f;
        health = 100; 
    }

    protected abstract void Attack(int amount);

    public abstract void TakeDamage(int amount);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
