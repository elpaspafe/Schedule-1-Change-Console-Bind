using MelonLoader;
using UnityEngine;
using ScheduleOne.UI;
using ConsoleUI = ScheduleOne.UI.ConsoleUI;

[assembly: MelonInfo(typeof(changeConsoleShortcut.Core), "changeConsoleShortcut", "1.0.0", "Yipikayei05", null)]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace changeConsoleShortcut
{
    public class Core : MelonMod
    {
        private MelonPreferences_Category prefs;
        private MelonPreferences_Entry<KeyCode> consoleKeyPref;

        private KeyCode customConsoleKey;
        private bool isAwaitingNewKey = false;

        public override void OnInitializeMelon()
        {
            prefs = MelonPreferences.CreateCategory("ConsoleShortcut");
            consoleKeyPref = prefs.CreateEntry("ConsoleKey", KeyCode.F1);
            customConsoleKey = consoleKeyPref.Value;

            LoggerInstance.Msg($"Initialized. Console key set to {customConsoleKey}");
        }

        public override void OnUpdate()
        {
            if (isAwaitingNewKey)
            {
                foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
                {
                    if (Input.GetKeyDown(key))
                    {
                        customConsoleKey = key;
                        consoleKeyPref.Value = key;
                        MelonPreferences.Save();

                        LoggerInstance.Msg($"New console key set to {key}");
                        isAwaitingNewKey = false;
                        break;
                    }
                }

                return;
            }

            if (Input.GetKeyDown(customConsoleKey))
            {
                ToggleConsoleManually();
            }

            if (Input.GetKeyDown(KeyCode.F10))
            {
                isAwaitingNewKey = true;
                LoggerInstance.Msg("Press a new key to assign for opening the console...");
            }
        }

        public void ToggleConsoleManually()
        {
            ConsoleUI console = UnityEngine.Object.FindObjectOfType<ConsoleUI>();
            if (console != null)
            {
                console.SetIsOpen(true);
                LoggerInstance.Msg("Console opened");
            }
            else
            {
                LoggerInstance.Warning("No instance of Console UI found");
            }
        }
    }
}
