﻿// Licensed to the Genometric organization (https://github.com/Genometric) under one or more agreements.
// The Genometric organization licenses this file to you under the GNU General Public License v3.0 (GPLv3).
// See the LICENSE file in the project root for more information.

using Genometric.GeUtilities.IGenomics;
using System;

namespace Genometric.MSPC.Core.Model
{
    public class SupportingPeak<I> : Peak<I>, IComparable<SupportingPeak<I>>
            where I : IChIPSeqPeak, new()
    {
        public SupportingPeak(I source, UInt32 sampleID):
            base(source)
        {
            SampleID = sampleID;
        }

        public UInt32 SampleID { private set; get; }

        public int CompareTo(SupportingPeak<I> other)
        {
            if (other == null) return 1;
            if (SampleID != other.SampleID)
                return SampleID.CompareTo(other.SampleID);
            return base.CompareTo(other);
        }
    }
}
