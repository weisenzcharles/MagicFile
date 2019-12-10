﻿// Copyright (c) Samuel Cragg.
//
// Licensed under the MIT license. See LICENSE file in the project root for
// full license information.

namespace SharpKml.Dom
{
    using System.Xml;

    /// <summary>
    /// Allows customized serialization of an <see cref="Element"/>.
    /// </summary>
    public interface ICustomElement
    {
        /// <summary>
        /// Gets a value indicating whether to process the children of the Element.
        /// </summary>
        bool ProcessChildren { get; }

        /// <summary>
        /// Writes the start of an XML element.
        /// </summary>
        /// <param name="writer">An <see cref="XmlWriter"/> to write to.</param>
        void CreateStartElement(XmlWriter writer);
    }
}
