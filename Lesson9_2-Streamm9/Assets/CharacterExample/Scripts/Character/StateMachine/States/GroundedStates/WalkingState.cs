public class WalkingState : SteppingState
{
    private readonly WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.WalkingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartWalking();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopWalking();
    }

    public override void Update()
    {
        base.Update();

    }
    public override float ReadHorizontalInput()
    {
        return Input.Movement.Walk.ReadValue<float>();

    }
}
