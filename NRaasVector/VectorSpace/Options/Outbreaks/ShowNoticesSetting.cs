﻿using NRaas.CommonSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Skills;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.VectorSpace.Options.Outbreaks
{
    public class ShowNoticesSetting : BooleanSettingOption<GameObject>, IOutbreaksOption
    {
        protected override bool Value
        {
            get
            {
                return Vector.Settings.mOutbreakShowNotices;
            }
            set
            {
                Vector.Settings.mOutbreakShowNotices = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "OutbreakShowNotices";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new ListingOption(); }
        }
    }
}
