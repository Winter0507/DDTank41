﻿using Game.Base.Packets;
using System;

namespace Game.Server.Packets.Client
{
  [Obsolete("已经不用")]
  [PacketHandler(35, "user ac action")]
  public class ACActionHandler : IPacketHandler
  {
    public int HandlePacket(GameClient client, GSPacketIn packet)
    {
      return 1;
    }
  }
}
