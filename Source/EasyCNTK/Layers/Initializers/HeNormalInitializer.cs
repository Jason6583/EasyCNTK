﻿//
// Copyright (c) Stanislav Grigoriev. All rights reserved.
// grigorievstas9@gmail.com 
// https://github.com/StanislavGrigoriev/EasyCNTK
//
// Copyright (c) Microsoft. All rights reserved.
//
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
using CNTK;

namespace EasyCNTK.Layers
{
    public class HeNormalInitializer : WeightsInitializer
    {
        private double _scaleFactor;
        public HeNormalInitializer(double scale = 1)
        {
            _scaleFactor = scale;
        }

        public override CNTKDictionary Create()
        {
            return CNTKLib.HeNormalInitializer(_scaleFactor);
        }
    }
}
