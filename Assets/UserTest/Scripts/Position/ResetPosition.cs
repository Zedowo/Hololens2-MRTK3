using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;

namespace Microsoft.MixedReality.Toolkit.SpatialManipulation
{
    public class ResetPosition : MonoBehaviour
    {
        private Quaternion startingPosition;


        // Start is called before the first frame update
        void Start()
        {

        }

        /*void onEnable()
        {
            startingPosition = transform.rotation;
        }

        void onDisable()
        {
            transform.rotation = startingPosition;
        }*/

        // Update is called once per frame
        void Update()
        {
           /* if (isGrabSelected)
            {
                startingPosition = transform.rotation;
                if (!isGrabSelected)
                {
                    transform.rotation = startingPosition;
                }
            }*/
        }
    }
}