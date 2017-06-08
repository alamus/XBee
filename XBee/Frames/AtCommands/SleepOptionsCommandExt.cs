﻿using BinarySerialization;

namespace XBee.Frames.AtCommands
{
    internal class SleepOptionsCommandExt : AtCommand
    {
        public SleepOptionsCommandExt() : base("SO")
        {
        }

        public SleepOptionsCommandExt(SleepOptionsExt options)
            : this()
        {
            Options = options;
        }

        [Ignore]
        public SleepOptionsExt? Options
        {
            get => Parameter as SleepOptionsExt?;
            set => Parameter = value;
        }
    }
}
