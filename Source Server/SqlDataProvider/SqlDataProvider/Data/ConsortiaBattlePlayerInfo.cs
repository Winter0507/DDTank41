﻿// Decompiled with JetBrains decompiler
// Type: SqlDataProvider.Data.ConsortiaBattlePlayerInfo
// Assembly: SqlDataProvider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E6C792E1-372D-46D0-B366-36ACC93C90BB
// Assembly location: C:\Users\Pham Van Hungg\Desktop\Decompiler\Road\SqlDataProvider.dll

using System;

namespace SqlDataProvider.Data
{
  public class ConsortiaBattlePlayerInfo
  {
    public int consortiaID { get; set; }

    public string consortiaName { get; set; }

    public int curHp { get; set; }

    public int failBuffCount { get; set; }

    public bool isDoubleScoreUsed { get; set; }

    public bool isPowerFullUsed { get; set; }

    public int PlayerID { get; set; }

    public int posX { get; set; }

    public int posY { get; set; }

    public int score { get; set; }

    public bool Sex { get; set; }

    public byte status { get; set; }

    public DateTime tombstoneEndTime { get; set; }

    public int victoryCount { get; set; }

    public int winningStreak { get; set; }
  }
}
