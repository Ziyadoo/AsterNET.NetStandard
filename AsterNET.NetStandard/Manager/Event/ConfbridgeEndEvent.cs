﻿namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeEndEvent : AbstractConfbridgeEvent
    {
        public ConfbridgeEndEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
