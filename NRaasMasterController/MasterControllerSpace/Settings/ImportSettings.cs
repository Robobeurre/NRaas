﻿using NRaas.CommonSpace.Helpers;
using NRaas.CommonSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Interfaces;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using Sims3.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace NRaas.MasterControllerSpace.Settings
{
    public class ImportSettings : OptionItem, ISettingOption
    {
        public ImportSettings()
        { }

        public override string GetTitlePrefix()
        {
            return "ImportSettings";
        }

        protected override OptionResult Run(GameHitParameters<GameObject> parameters)
        {
            if (FilePersistence.ImportFromFile())
            {
                return OptionResult.SuccessClose;
            }
            else
            {
                return OptionResult.Failure;
            }
        }
    }
}
