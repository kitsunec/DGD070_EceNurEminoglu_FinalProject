using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class Oyun : MonoBehaviour
{
    private Contexts _contexts;
    private PlayerHealthFeature PlayerHealthFeature;
    private ChangePlayerHealthSystem ChangePlayerHealthSystem;
    private CreatePlayerHealthSystem CreatePlayerHealthSystem;
    private CheckPlayerHealthSystem CheckPlayerHealthSystem;

    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        ChangePlayerHealthSystem = new ChangePlayerHealthSystem(_contexts);
        PlayerHealthFeature = new PlayerHealthFeature(_contexts);
        CheckPlayerHealthSystem = new CheckPlayerHealthSystem(_contexts);
        CreatePlayerHealthSystem = new CreatePlayerHealthSystem(_contexts);
        CreatePlayerHealthSystem.Initialize();
    }

    private void Update()
    {
        ChangePlayerHealthSystem.Execute();
        
        CheckPlayerHealthSystem.Execute();
    }
}