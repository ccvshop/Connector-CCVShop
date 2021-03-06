﻿using Connector.CcvShop.Api.Base;
using System;

// This file is generated by the Converttool in the solution Connector.CcvShop.
namespace Connector.CcvShop.Api.Categories
{
    public class CategoryResult : ResultBase
    {
        /// <summary>
        /// <summary>
        /// Unique id of the resource
        /// Minimum: 0
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// <summary>
        /// Category name
        /// Maxlength: 255
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// <summary>
        /// Category description
        /// Maxlength: 65536
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// <summary>
        /// Category description
        /// </summary>
        public string description_photo_size { get; set; }

        /// <summary>
        /// <summary>
        /// Category description
        /// </summary>
        public string description_photo_position { get; set; }

        /// <summary>
        /// <summary>
        /// Category description
        /// </summary>
        public string description_photo { get; set; }

        /// <summary>
        /// <summary>
        /// Category description on the bottom of the page
        /// Maxlength: 65536
        /// </summary>
        public string description_bottom { get; set; }

        /// <summary>
        /// <summary>
        /// Search keywords
        /// </summary>
        public string searchwords { get; set; }

        /// <summary>
        /// <summary>
        /// Category photo
        /// </summary>
        public string photo { get; set; }

        /// <summary>
        /// <summary>
        /// Show a larger photo on mouseover.
        /// </summary>
        public bool? show_big_photo { get; set; }

        /// <summary>
        /// <summary>
        /// Product photos will be zoomed in and cropped onto a canvas. Only used in certain category layouts.
        /// </summary>
        public bool? productphoto_in_canvas { get; set; }

        /// <summary>
        /// <summary>
        /// Show the product order button.
        /// </summary>
        public bool? show_orderbutton { get; set; }

        /// <summary>
        /// <summary>
        /// The order in which the products are sorted in this category
        /// </summary>
        /// <value>position</value>
        /// <value>productname</value>
        /// <value>productnumber</value>
        /// <value>createdate</value>
        /// <value>price</value>
        /// <value>price_desc</value>
        /// <value>discount_desc</value>
        public string orderby { get; set; }

        /// <summary>
        /// <summary>
        /// Number of items per page
        /// Minimum: 0
        /// Maximum: 100
        /// </summary>
        public int? items_per_page { get; set; }

        /// <summary>
        /// <summary>
        /// Category position
        /// Minimum: 0
        /// </summary>
        public int? position { get; set; }

        /// <summary>
        /// <summary>
        /// The layout id of the sub categories in this category. 1: Images with category name. 2: List with category names. 3: Images with sliding category name.4: Images in enlarging blocks.5: Large images with sliding category name. 2001: ProTOM lay-out SubCategory1.sub.tpl. 2002: ProTOM lay-out SubCategory2.sub.tpl.
        /// Minimum: 1
        /// </summary>
        public int? layout_of_categories_id { get; set; }

        /// <summary>
        /// <summary>
        /// Category visible on website
        /// </summary>
        public bool? show_on_website { get; set; }

        /// <summary>
        /// <summary>
        /// Color scheme number. Only used in certain category layouts.1: Blue. 2: Yellow. 3: Gray. 4: Green. 5: Orange. 6: Purple. 7: Red.
        /// </summary>
        public int? color { get; set; }

        /// <summary>
        /// <summary>
        /// Alternative color scheme. Only used in certain category layouts. 1: Blue. 2: Yellow. 3: Gray. 4: Green. 5: Orange. 6: Purple. 7: Red.
        /// </summary>
        public int? color_alternative { get; set; }

        /// <summary>
        /// <summary>
        /// Metatag Description
        /// </summary>
        public string meta_description { get; set; }

        /// <summary>
        /// <summary>
        /// Metatag Keywords
        /// </summary>
        public string meta_keywords { get; set; }

        /// <summary>
        /// <summary>
        /// Page title
        /// </summary>
        public string page_title { get; set; }

        /// <summary>
        /// <summary>
        /// Metatag robots: No-Index
        /// </summary>
        public bool? no_index { get; set; }

        /// <summary>
        /// <summary>
        /// Metatag robots: No-Follow
        /// </summary>
        public bool? no_follow { get; set; }

        /// <summary>
        /// <summary>
        /// SEO Alias of this resource
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// <summary>
        /// Deeplink to this resource
        /// </summary>
        public string deeplink { get; set; }

    }
}