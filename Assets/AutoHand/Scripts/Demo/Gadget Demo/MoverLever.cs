using UnityEngine;
using Autohand;

namespace Autohand.Demo{
    public class MoverLever : PhysicsGadgetHingeAngleReader{
        public Transform move;
        public DialHandScaler dial;
        public Vector3 axis;
        public float speed = 1;
    
        void Update()
        {
            if (!move) return;
            if(Mathf.Abs(GetValue()) > 0.1f)
                move.position += move.forward * (GetValue() * speed * Time.deltaTime);
        }
    }
}
