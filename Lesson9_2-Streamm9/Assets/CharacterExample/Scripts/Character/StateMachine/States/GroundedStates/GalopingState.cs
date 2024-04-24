public class GalopingState : SteppingState
{
    private readonly GalopingStateConfig _config;

    public GalopingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.GalopingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartGaloping();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopGaloping();
    }

    public override void Update()
    {
        base.Update();

    }

    public override float ReadHorizontalInput()
    {
        return Input.Movement.Galop.ReadValue<float>();
        
    }
}
