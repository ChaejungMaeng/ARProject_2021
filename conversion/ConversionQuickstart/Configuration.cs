// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Numerics;
using Azure.MixedReality.ObjectAnchors.Conversion;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConversionQuickstart
{
    public class Configuration
    {
        // Azure Object Anchors account identifier
        public string AccountId = "86001338-9457-48ae-bd6f-b68a27fe54f6";

        // Azure Object Anchors account primary key
        public string AccountKey = "TfLH8R13/2k++FTlAauDTUv6TdeNtDIxb69A4d6dwhM=";

        // Azure Object Anchors account domain
        public string AccountDomain = "eastus2.mixedreality.azure.com";

        // Path to 3D asset file on your local machine
        public string InputAssetPath = "C:/Users/uvrla/OneDrive/Desktop/Model/wine thin glass.fbx";

        //C:\Users\uvrla\OneDrive\Desktop\azure-object-anchors-main\quickstarts\conversion\ConversionQuickstart\Model

        // Timeout to wait for job completion
        public TimeSpan WaitForJobCompletionTimeout = TimeSpan.FromMinutes(40);

        // Gravity direction of 3D model
        public Vector3 Gravity = new Vector3(0.0f, -1.0f, 0.0f);

        // The unit of measurement of the 3D model
        [JsonConverter(typeof(StringEnumConverter))]
        public AssetLengthUnit AssetDimensionUnit = AssetLengthUnit.Meters;

        [JsonIgnore]
        public ILogger Logger = NullLogger.Instance;
    }
}
