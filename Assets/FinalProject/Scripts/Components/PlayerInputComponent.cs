using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Unique, Input]
public class PlayerInputComponent : IComponent
{
    public Vector2 Value;
}
