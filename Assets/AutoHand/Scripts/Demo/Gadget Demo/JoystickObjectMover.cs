using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Autohand.Demo{
    public class JoystickObjectMover : PhysicsGadgetJoystick{
        public Transform move;
        public DialHandScaler dial;
        public float speed = 2;
        public float x;
        public float y;
        void Update(){
            var axis = GetValue();
            x=axis.x;
            y = axis.y;
            float rotationSpeed = speed * Time.deltaTime;
            float xRotation = axis.y * rotationSpeed; // invert if needed
            float yRotation = axis.x * rotationSpeed;
if(move)
            // Apply rotation (rotate around X and Y axes)
            move.transform.Rotate(xRotation, 0, yRotation, Space.Self);
        }
    }
}
