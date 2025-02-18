using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButton : Interactable
{
    private Animator _animatior;
    public GameObject Puerta;

    private void Awake()
    {
        _animatior = GetComponent<Animator>();
    }

    public override void Interact()
    {
        _animatior.SetTrigger("Active");
        Puerta.SetActive(false);
    }
}
