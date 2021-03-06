﻿// Copyright (c) Samuel Cragg.
//
// Licensed under the MIT license. See LICENSE file in the project root for
// full license information.

namespace SharpKml.Dom.Xal
{
    using SharpKml.Base;

    /// <summary>
    /// Represents an administrative area.
    /// </summary>
    /// <remarks>
    /// Examples of include provinces, counties, special regions (such as "Rijnmond").
    /// </remarks>
    [KmlElement("AdministrativeArea", KmlNamespaces.XalNamespace)]
    public class AdministrativeArea : Element
    {
        private Locality locality;
        private SubAdministrativeArea subArea;

        /// <summary>
        /// Gets or sets the <see cref="Locality"/> associated with this instance.
        /// </summary>
        [KmlElement(null)]
        public Locality Locality
        {
            get => this.locality;
            set => this.UpdatePropertyChild(value, ref this.locality);
        }

        /// <summary>
        /// Gets or sets the name of the administrative area.
        /// </summary>
        [KmlElement("AdministrativeAreaName", KmlNamespaces.XalNamespace)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="SubAdministrativeArea"/> associated
        /// with this instance.
        /// </summary>
        [KmlElement(null)]
        public SubAdministrativeArea SubAdministrativeArea
        {
            get => this.subArea;
            set => this.UpdatePropertyChild(value, ref this.subArea);
        }
    }
}
