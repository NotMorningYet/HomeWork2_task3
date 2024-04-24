using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;
    [SerializeField] private WalkingStateConfig _walkingStateConfig;
    [SerializeField] private GalopingStateConfig _galopingStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
    public GalopingStateConfig GalopingStateConfig => _galopingStateConfig;
}
