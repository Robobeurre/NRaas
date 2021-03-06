﻿using NRaas.CommonSpace.Interactions;
using NRaas.CommonSpace.Options;
using NRaas.PorterSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Objects.Electronics;
using Sims3.Gameplay.Objects.RabbitHoles;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.PorterSpace.Interactions
{
    public class LotInteraction : CommonInteraction<ILotOption, GameObject>
    {
        public static InteractionDefinition Singleton = new CommonDefinition<LotInteraction>(true, true);

        public override void AddInteraction(Common.InteractionInjectorList interactions)
        {
            interactions.Add<Lot>(Singleton);
            interactions.Add<BuildableShell>(Singleton);
        }

        protected override bool Test(IActor a, GameObject target, GameObjectHit hit, ref GreyedOutTooltipCallback greyedOutTooltipCallback)
        {
            Lot lot = Porter.GetLot(target);
            if (lot == null) return false;

            return lot.IsResidentialLot;
        }

        protected override OptionResult Perform(IActor actor, GameObject target, GameObjectHit hit)
        {
            throw new NotImplementedException();
        }
    }
}
