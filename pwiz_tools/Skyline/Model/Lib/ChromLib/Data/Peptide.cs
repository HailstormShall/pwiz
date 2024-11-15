﻿/*
 * Original author: Nick Shulman <nicksh .at. u.washington.edu>,
 *                  MacCoss Lab, Department of Genome Sciences, UW
 *
 * Copyright 2013 University of Washington - Seattle, WA
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using JetBrains.Annotations;

namespace pwiz.Skyline.Model.Lib.ChromLib.Data
{
    [UsedImplicitly]
    public class Peptide : ChromLibEntity<Peptide>
    {
        public virtual Protein Protein { get; set; }
        public virtual string Sequence { get; set; }
        public virtual int StartIndex { get; set; }
        public virtual int EndIndex { get; set; }
        public virtual char PreviousAa { get; set; }
        public virtual char NextAa { get; set; }
        public virtual double CalcNeutralMass { get; set; }
        public virtual int NumMissedCleavages { get; set; }

        /// <summary>
        /// Schema version 1.3 added small molecule support
        /// </summary>
        [UsedImplicitly]
        public class Format1Dot3 : Peptide
        {
            public virtual string ChemicalFormula { get; set; }
            public virtual string MoleculeName { get; set; }
            public virtual double MassMonoisotopic { get; set; }
            public virtual double MassAverage { get; set; }
            public virtual string MoleculeAccession { get; set; }
        }
    }
}
