using System;
using UnityEngine;

[Serializable]
public class GalopingStateConfig
{
    [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
}