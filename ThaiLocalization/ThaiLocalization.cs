using HarmonyLib;
using OWML.Common;
using OWML.ModHelper;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace ThaiLocalization
{
    public class ThaiLocalization : ModBehaviour
    {
        public static ThaiLocalization Instance;
        public static string translationFile = "translations/translation.xml";

        private void Awake()
        {
        }

        private void Start()
        {
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Thai", translationFile);
			api.AddLanguageFont(this, "Thai", "fonts/kanchamay", "fonts/KanchaMay.ttf");

            //Quark-Bold.otf

            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(ThaiLocalization)} is loaded!", MessageType.Success);
        }
    }
}