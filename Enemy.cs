using System;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    public Mover Mover;

    private void Awake()
    {
        Mover = GetComponent<Mover>();
    }
}