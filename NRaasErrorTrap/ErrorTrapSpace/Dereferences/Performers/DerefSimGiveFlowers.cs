﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.ErrorTrapSpace.Dereferences
{
    public class DerefSimGiveFlowers : Dereference<Sim.GiveFlowers>
    {
        protected override DereferenceResult Perform(Sim.GiveFlowers reference, FieldInfo field, List<ReferenceWrapper> objects)
        {
            if (Matches(reference, "FlowerObject", field, objects))
            {
                if (Performing)
                {
                    try
                    {
                        reference.Cleanup();
                    }
                    catch
                    { }

                    Remove(ref reference.FlowerObject);
                }

                return DereferenceResult.ContinueIfReferenced;
            }

            return DereferenceResult.Failure;
        }
    }
}
