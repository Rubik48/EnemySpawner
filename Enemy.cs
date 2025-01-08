using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    public Mover Mover => GetComponent<Mover>();
}