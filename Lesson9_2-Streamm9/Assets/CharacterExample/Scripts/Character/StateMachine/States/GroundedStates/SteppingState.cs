using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class SteppingState : GroundedState
{
    protected SteppingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    
    }

    public override void Enter()
    {
        base.Enter();

        View.StartStepping();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopStepping();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();

        SelectSteppingState();
    }
    
}
