using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    // Root myDeserializedClass = JsonConvert.Deserializestring<Root>(myJsonResponse); 
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
        public string src { get; set; }
        public string alt { get; set; }
        public string hash { get; set; }
        public string src_small { get; set; }
        public string src_medium { get; set; }
        public string src_large { get; set; }
        public string youtube_video_id { get; set; }
    }

    public class Attribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public bool variation { get; set; }
        public List<string> options { get; set; }
        public string option { get; set; }
    }

    public class DefaultAttribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public string option { get; set; }
    }

    public class CustomFields
    {
        public string to_hide { get; set; }
        public string cost { get; set; }
        public string customer_tiers_on_sale { get; set; }
        public string variation_barcode { get; set; }
        public string variation_shelf { get; set; }
        public string minprice { get; set; }
        public string conversionrategroup { get; set; }
        public string conversionrate { get; set; }
        public string sales_item { get; set; }
        public string internal_sales_item { get; set; }
        public string inventory_item { get; set; }
        public string to_hide_during_picking_and_packing { get; set; }
        public string source { get; set; }
        public string disallow_children_backorders { get; set; }
        public string group { get; set; }
        public string date_valid_from { get; set; }
        public string date_valid_to { get; set; }
        public string internal_description { get; set; }
        public string discontinued { get; set; }
        public string customer_tiers { get; set; }
        public string barcode { get; set; }
        public string is_rack_barcode { get; set; }
        public string customers { get; set; }
        public string price_tags { get; set; }
    }

    public class Inventory
    {
        public int branch_id { get; set; }
        public string batch_id { get; set; }
        public double stock_quantity { get; set; }
        public double physical_stock_quantity { get; set; }
        public string updated_at { get; set; }
    }

    public class Variation
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string description { get; set; }
        public string regular_price { get; set; }
        public string sale_price { get; set; }
        public string date_on_sale_from { get; set; }
        public string date_on_sale_to { get; set; }
        public string tax_class { get; set; }
        public bool manage_stock { get; set; }
        public double stock_quantity { get; set; }
        public bool in_stock { get; set; }
        public string backorders { get; set; }
        public bool backorders_allowed { get; set; }
        public bool backordered { get; set; }
        public string weight { get; set; }
        public Dimensions dimensions { get; set; }
        public string shipping_class { get; set; }
        public int shipping_class_id { get; set; }
        public List<string> image { get; set; }
        public List<Attribute> attributes { get; set; }
        public CustomFields custom_fields { get; set; }
        public string points_earned { get; set; }
        public string points_required { get; set; }
        public string maximum_points_discount { get; set; }
        public string insurance_class { get; set; }
        public string insurance_class_id { get; set; }
        public List<Inventory> inventory { get; set; }
    }

    public class MixedSkuVolumePricingGroup
    {
        public List<string> product_ids { get; set; }
        public List<string> product_attributes { get; set; }
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
        public List<Self> self { get; set; }
        public List<Collection> collection { get; set; }
    }

    public class Catalog
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date_modified { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string catalog_visibility { get; set; }
        public string description { get; set; }
        public string sku { get; set; }
        public string regular_price { get; set; }
        public string sale_price { get; set; }
        public string date_on_sale_from { get; set; }
        public string date_on_sale_to { get; set; }
        public string tax_class { get; set; }
        public bool manage_stock { get; set; }
        public string stock_quantity { get; set; }
        public bool in_stock { get; set; }
        public string backorders { get; set; }
        public bool backorders_allowed { get; set; }
        public bool backordered { get; set; }
        public string weight { get; set; }
        public Dimensions dimensions { get; set; }
        public string shipping_class { get; set; }
        public int shipping_class_id { get; set; }
        public List<string> cross_sell_ids { get; set; }
        public List<Category> categories { get; set; }
        public List<Image> image { get; set; }
        public List<Attribute> attributes { get; set; }
        public List<DefaultAttribute> default_attributes { get; set; }
        public List<Variation> variations { get; set; }
        public int menu_order { get; set; }
        public string composite_layout { get; set; }
        public List<string> composite_components { get; set; }
        public List<string> composite_scenarios { get; set; }
        public string bundle_layout { get; set; }
        public List<string> bundled_by { get; set; }
        public List<string> bundled_items { get; set; }
        public MixedSkuVolumePricingGroup mixed_sku_volume_pricing_group { get; set; }
        public CustomFields custom_fields { get; set; }
        public List<string> pricing_groups { get; set; }
        public string composite_product_details { get; set; }
        public string bundle_product_details { get; set; }
        public int group_of { get; set; }
        public string minimum_quantity { get; set; }
        public string maximum_quantity { get; set; }
        public string insurance_class { get; set; }
        public string insurance_class_id { get; set; }
        public Links _links { get; set; }
    }


}
