﻿using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Academics;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Core;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Objects;
using Sims3.Gameplay.Objects.Electronics;
using Sims3.Gameplay.Services;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using Sims3.SimIFace.CAS;
using Sims3.UI;
using Sims3.UI.CAS;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.OverwatchSpace.Loadup
{
    public class ClearInvalidTimeTravelerServiceRequests : ImmediateLoadupOption
    {
        public override string GetTitlePrefix()
        {
            return "ClearInvalidTimeTravelerServiceRequests";
        }

        public override void OnWorldLoadFinished()
        {
            Overwatch.Log(GetTitlePrefix());

            TimeTraveler service = TimeTraveler.Instance;
            List<ulong> remove = new List<ulong>();
            if (service != null)
            {
                foreach (KeyValuePair<ulong, Service.ServiceRequest> pair in service.mLotsRequested)
                {
                    if (!service.mTimeTravelerServiceRequests.ContainsKey(pair.Key))
                    {
                        remove.Add(pair.Key);
                    }
                }

                foreach (ulong num in remove)
                {
                    Lot lot = LotManager.GetLot(num);
                    if (lot != null)
                    {
                        service.ClearServiceForLot(lot);
                    }
                    else
                    {
                        service.mLotsRequested.Remove(num);
                    }
                    Overwatch.Log("Removed invalid Time Traveler service request");
                }
            }
        }
    }
}
