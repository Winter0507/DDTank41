﻿// Decompiled with JetBrains decompiler
// Type: Game.Server.Packets.Client.GoodsCountHandler
// Assembly: Game.Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7994645F-6854-4AAC-A332-C61842D2DD9F
// Assembly location: C:\Users\Pham Van Hungg\Desktop\Decompiler\Road\Game.Server.dll

using Game.Base.Packets;
using Game.Server.Managers;
using SqlDataProvider.Data;
using System.Collections.Generic;

namespace Game.Server.Packets.Client
{
  [PacketHandler(168, "物品强化")]
  public class GoodsCountHandler : IPacketHandler
  {
    public int HandlePacket(GameClient client, GSPacketIn packet)
    {
      List<ShopFreeCountInfo> allShopFreeCount = WorldMgr.GetAllShopFreeCount();
      client.Out.SendShopGoodsCountUpdate(allShopFreeCount);
      return 0;
    }
  }
}
