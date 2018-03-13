﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Alberto Rodríguez Orozco & LiveCharts contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
// of the Software, and to permit persons to whom the Software is furnished to 
// do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

#region

using LiveCharts.Core.Drawing.Svg;

#endregion

namespace LiveCharts.Core.Abstractions.DataSeries
{
    /// <summary>
    /// The scatter series interface.
    /// </summary>
    /// <seealso cref="LiveCharts.Core.Abstractions.DataSeries.ISeries" />
    public interface IScatterSeries : ISeries
    {
        /// <summary>
        /// Gets or sets the point geometry.
        /// </summary>
        /// <value>
        /// The point geometry.
        /// </value>
        Geometry PointGeometry { get; set; }

        /// <summary>
        /// Gets or sets the maximum point diameter.
        /// </summary>
        /// <value>
        /// The maximum point diameter.
        /// </value>
        float MaxPointDiameter { get; set; }

        /// <summary>
        /// Gets or sets the minimum point diameter.
        /// </summary>
        /// <value>
        /// The minimum point diameter.
        /// </value>
        float MinPointDiameter { get; set; }
    }
}