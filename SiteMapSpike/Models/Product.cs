// <copyright file="Product.cs" company="MyCompany.com">
// Copyright (c) 2016 MyCompany.com. All rights reserved.
// </copyright>
// <author>Mpho. Majenge</author>
// <date>2016-06-26</date>
// <summary>Implements the product class</summary>
namespace SiteMapSpike
{
    public class Product : Warehouse
    {
        /// <summary>
        /// Gets or sets the identifier of the product.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string ProductDescripion { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        public decimal Price { get; set; }
    }

}