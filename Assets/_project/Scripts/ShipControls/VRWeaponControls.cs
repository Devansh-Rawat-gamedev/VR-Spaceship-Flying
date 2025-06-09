using UnityEngine;

namespace _project.Scripts.ShipControls
{
    public class VRWeaponControls : WeaponControlsBase
    {
         bool firing;
         bool secondaryFiring;
        public override bool PrimaryFired => firing;
        public override bool SecondaryFired => secondaryFiring;

        public void PrimaryFire(bool val)
        {
            firing = val;
        }
        public void SecondaryFire(bool val)
        {
            secondaryFiring = val;
        }
    }
}
