// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents image preprocessing settings used by image augmentation.
    /// </summary>
    public partial class ImageProcessingSettings
    {
        /// <summary>
        /// Initializes a new instance of the ImageProcessingSettings class.
        /// </summary>
        public ImageProcessingSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageProcessingSettings class.
        /// </summary>
        /// <param name="augmentationMethods">Gets or sets enabled image
        /// transforms. The key corresponds to the transform name. If value is
        /// set to true, then correspondent transform is enabled. Otherwise
        /// this transform will not be used.
        /// Augmentation will be uniformly distributed among enabled
        /// transforms.</param>
        public ImageProcessingSettings(IDictionary<string, bool?> augmentationMethods = default(IDictionary<string, bool?>))
        {
            AugmentationMethods = augmentationMethods;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enabled image transforms. The key corresponds to the
        /// transform name. If value is set to true, then correspondent
        /// transform is enabled. Otherwise this transform will not be used.
        /// Augmentation will be uniformly distributed among enabled
        /// transforms.
        /// </summary>
        [JsonProperty(PropertyName = "augmentationMethods")]
        public IDictionary<string, bool?> AugmentationMethods { get; set; }

    }
}
