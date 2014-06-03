﻿using System;

namespace PVPNetConnect.RiotObjects.Gameinvite.Contract
{
    public class Inviter : RiotGamesObject
    {
        public override string TypeName
        {
            get { return this.type; }
        }

        private string type = "com.riotgames.platform.gameinvite.contract.Inviter";

        public Inviter()
        {
        }

        public Inviter(Callback callback)
        {
            this.callback = callback;
        }

        public Inviter(TypedObject result)
        {
            base.SetFields(this, result);
        }

        public delegate void Callback(Inviter result);

        private Callback callback;

        public override void DoCallback(TypedObject result)
        {
            base.SetFields(this, result);
            callback(this);
        }

        [InternalName("previousSeasonHighestTier")]
        public String previousSeasonHighestTier { get; set; }

        [InternalName("summonerName")]
        public String summonerName { get; set; }

        [InternalName("summonerId")]
        public Int16 summonerId { get; set; }

    }
}