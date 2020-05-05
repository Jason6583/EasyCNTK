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
    public class HeUniformInitializer : WeightsInitializer
    {
        private double _scaleFactor;
        public HeUniformInitializer(double scale = 1)
        {
            _scaleFactor = scale;
        }
        public override CNTKDictionary Create()
        {
            return CNTKLib.HeUniformInitializer(_scaleFactor);
        }
    }
}