// <copyright file="ProductCategory.cs" company="MyCompany.com">
// Copyright (c) 2016 MyCompany.com. All rights reserved.
// </copyright>
// <author>Mpho. Majenge</author>
// <date>2016-06-26</date>
// <summary>Implements the product category class</summary>

using System.Collections.Generic;

namespace SiteMapSpike
{
    /// <summary>
    /// A product category.
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        public virtual ICollection<Product> Products { get; set; }
    }
}