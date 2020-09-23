using System;
using System.Collections.Generic;
using System.Text;

namespace WooCommerceAPI.Models
{
    public class Dimensions
    {
        public string length { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Image
    {
        public int id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_created_gmt { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_modified_gmt { get; set; }
        public string src { get; set; }
        public string name { get; set; }
        public string alt { get; set; }
    }

    public class Attribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public bool variation { get; set; }
        public IList<string> options { get; set; }
    }

    public class DefaultAttribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public string option { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Collection
    {
        public string href { get; set; }
    }

    public class Links
    {
        public IList<Self> self { get; set; }
        public IList<Collection> collection { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string permalink { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_created_gmt { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_modified_gmt { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public bool featured { get; set; }
        public string catalog_visibility { get; set; }
        public string description { get; set; }
        public string short_description { get; set; }
        public string sku { get; set; }
        public string price { get; set; }
        public string regular_price { get; set; }
        public string sale_price { get; set; }
        public object date_on_sale_from { get; set; }
        public object date_on_sale_from_gmt { get; set; }
        public object date_on_sale_to { get; set; }
        public object date_on_sale_to_gmt { get; set; }
        public string price_html { get; set; }
        public bool on_sale { get; set; }
        public bool purchasable { get; set; }
        public int total_sales { get; set; }
        public bool virtual_product { get; set; }
        public bool downloadable { get; set; }
        public IList<object> downloads { get; set; }
        public int download_limit { get; set; }
        public int download_expiry { get; set; }
        public string external_url { get; set; }
        public string button_text { get; set; }
        public string tax_status { get; set; }
        public string tax_class { get; set; }
        public bool manage_stock { get; set; }
        public object stock_quantity { get; set; }
        public string stock_status { get; set; }
        public string backorders { get; set; }
        public bool backorders_allowed { get; set; }
        public bool backordered { get; set; }
        public bool sold_individually { get; set; }
        public string weight { get; set; }
        public Dimensions dimensions { get; set; }
        public bool shipping_required { get; set; }
        public bool shipping_taxable { get; set; }
        public string shipping_class { get; set; }
        public int shipping_class_id { get; set; }
        public bool reviews_allowed { get; set; }
        public string average_rating { get; set; }
        public int rating_count { get; set; }
        public IList<int> related_ids { get; set; }
        public IList<object> upsell_ids { get; set; }
        public IList<object> cross_sell_ids { get; set; }
        public int parent_id { get; set; }
        public string purchase_note { get; set; }
        public IList<Category> categories { get; set; }
        public IList<object> tags { get; set; }
        public IList<Image> images { get; set; }
        public IList<Attribute> attributes { get; set; }
        public IList<DefaultAttribute> default_attributes { get; set; }
        public IList<object> variations { get; set; }
        public IList<object> grouped_products { get; set; }
        public int menu_order { get; set; }
        public IList<object> meta_data { get; set; }
        public Links _links { get; set; }
    }
}
