﻿using System;

namespace AbstractFactory
{
    internal class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine(this + " interac " + water + " interact " + cover);
        }
    }
}