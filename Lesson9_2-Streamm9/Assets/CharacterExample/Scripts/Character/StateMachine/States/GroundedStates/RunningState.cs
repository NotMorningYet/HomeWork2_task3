public class RunningState : SteppingState
{
    private readonly RunningStateConfig _config;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit(); 
        
        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

    }

    public override float ReadHorizontalInput()
    {
        return Input.Movement.Move.ReadValue<float>();
    }
}
