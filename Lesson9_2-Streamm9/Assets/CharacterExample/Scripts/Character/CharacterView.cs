using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterView : MonoBehaviour
{
    private const string IsIdling = "IsIdling";
    private const string IsRunning = "IsRunning";
    private const string IsGrounded = "IsGrounded";
    private const string IsJumping = "IsJumping";
    private const string IsFalling = "IsFalling";
    private const string IsAirborne = "IsAirborne";
    private const string IsMovement = "IsMovement";
    private const string IsGaloping = "IsGaloping";
    private const string IsWalking = "IsWalking";
    private const string IsStepping = "IsStepping";


    private Animator _animator;

    public void Initialize() => _animator = GetComponent<Animator>();

    public void StartIdling() => _animator.SetBool(IsIdling, true);
    public void StopIdling() => _animator.SetBool(IsIdling, false);

    public void StartRunning() => _animator.SetBool(IsRunning, true);
    public void StopRunning() => _animator.SetBool(IsRunning, false);

    public void StartGrounded() => _animator.SetBool(IsGrounded, true);
    public void StopGrounded() => _animator.SetBool(IsGrounded, false);

    public void StartJumping() => _animator.SetBool(IsJumping, true);
    public void StopJumping() => _animator.SetBool(IsJumping, false);

    public void StartFalling() => _animator.SetBool(IsFalling, true);
    public void StopFalling() => _animator.SetBool(IsFalling, false);

    public void StartAirborne() => _animator.SetBool(IsAirborne, true);
    public void StopAirborne() => _animator.SetBool(IsAirborne, false);

    public void StartMovement() => _animator.SetBool(IsMovement, true);
    public void StopMovement() => _animator.SetBool(IsMovement, false);

    public void StartStepping() => _animator.SetBool(IsStepping, true);
    public void StopStepping() => _animator.SetBool(IsStepping, false);

    public void StartGaloping() => _animator.SetBool(IsGaloping, true);
    public void StopGaloping() => _animator.SetBool(IsGaloping, false);
    public void StartWalking() => _animator.SetBool(IsWalking, true);
    public void StopWalking() => _animator.SetBool(IsWalking, false);
}
