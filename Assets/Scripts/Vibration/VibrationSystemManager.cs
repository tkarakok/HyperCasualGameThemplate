using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.NiceVibrations;


namespace Tolian.VibrationSystem
{
    public static class VibrationSystemManager
    {
        public static void Vibrate(HapticTypes targetHapticType)
        {
            MMVibrationManager.Haptic(targetHapticType);
        }
    }
}
