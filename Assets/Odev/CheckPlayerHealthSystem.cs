using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private Contexts _contexts;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        
        _contexts = contexts;
        
    }

    public void Execute()
    {
        GameEntity[] NPC = _contexts.game.GetEntities();

        foreach (GameEntity n in NPC)
        {
            if (n.hasPlayerHealth)
            {
                if (n.isPlayerDamaged)
                {
                    float can = n.playerHealth.Value - 10;

                    if (can < 0)
                        can = 0;
                    

                    n.ReplacePlayerHealth(can);
                    n.isPlayerDamaged = false;
                }

                if (n.isPlayerHealed)
                {
                    float can = n.playerHealth.Value + 10;

                    if (can > 100)
                        can = 100;
                    

                    n.ReplacePlayerHealth(can);
                    n.isPlayerHealed = false;
                }
            }
        }
    }
}