﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.ErrorTrapSpace.Dereferences
{
    public class DerefTraitFunctionsCowardTraitRunAway : Dereference<TraitFunctions.CowardTraitRunAway>
    {
        protected override DereferenceResult Perform(TraitFunctions.CowardTraitRunAway reference, FieldInfo field, List<ReferenceWrapper> objects)
        {
            if (Matches(reference, "ScaryObject", field, objects))
            {
                Remove(ref reference.ScaryObject);
                return DereferenceResult.ContinueIfReferenced;
            }

            return DereferenceResult.Failure;
        }
    }
}
