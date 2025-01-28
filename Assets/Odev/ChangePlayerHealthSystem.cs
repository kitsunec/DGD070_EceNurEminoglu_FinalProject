using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    
    private Contexts _contexts;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
        
    }

    public void Execute()
    {
        GameEntity[] NPC = _contexts.game.GetEntities(GameMatcher.PlayerHealth);

        foreach (GameEntity n in NPC)
        {
            
            if (Input.GetKeyDown(KeyCode.D))
                n.isPlayerDamaged = true;
            

            if (Input.GetKeyDown(KeyCode.H))
                n.isPlayerHealed = true;
            
            
        }
    }
}