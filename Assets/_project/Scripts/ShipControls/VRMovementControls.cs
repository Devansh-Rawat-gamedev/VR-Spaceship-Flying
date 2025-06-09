using Autohand.Demo;
using UnityEngine;

namespace _project.Scripts.ShipControls
{
    public class VRMovementControls : MovementControlsBase
    {
        [SerializeField]JoystickObjectMover _joystickObjectMover;
        [SerializeField]MoverLever _moverLever;
        public override float YawAmount { get; }

        public override float PitchAmount => _joystickObjectMover.GetValue().y;

        public override float RollAmount => -_joystickObjectMover.GetValue().x;

        public override float ThrustAmount => _moverLever.GetValue();
    }
}
