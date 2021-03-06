using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityTest
{
    public class IntegrationTestsRunnerSettings : ProjectSettingsBase
    {
        public bool addNewGameObjectUnderSelectedTest;
        public bool blockUIWhenRunning = true;
        public bool pauseOnTestFailure;

        public void ToggleAddNewGameObjectUnderSelectedTest ()
        {
            addNewGameObjectUnderSelectedTest = !addNewGameObjectUnderSelectedTest;
            Save ();
        }
        
        public void ToggleBlockUIWhenRunning ()
        {
            blockUIWhenRunning = !blockUIWhenRunning;
            Save ();
        }
        
        public void TogglePauseOnTestFailure()
        {
            pauseOnTestFailure = !pauseOnTestFailure;
            Save ();
        }
    }
}
