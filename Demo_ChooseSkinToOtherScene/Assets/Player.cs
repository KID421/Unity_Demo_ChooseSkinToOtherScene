using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().color = ColorSystem.playerColor;

        GetComponent<Animator>().runtimeAnimatorController = ColorSystem.controller;
    }
}
