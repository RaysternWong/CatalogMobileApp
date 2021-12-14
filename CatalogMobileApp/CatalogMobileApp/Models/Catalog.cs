using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace CatalogMobileApp.Models
{
    public class Catalog
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("catalog_visibility")]
        public string CatalogVisibility { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("regular_price")]
        public string RegularPrice { get; set; }
        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }
        [JsonProperty("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }
        [JsonProperty("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }
        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }
        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; }
        [JsonProperty("stock_quantity")]
        public double? StockQuantity { get; set; }
        [JsonProperty("in_stock")]
        public bool InStock { get; set; }
        [JsonProperty("backorders")]
        public string Backorders { get; set; }
        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }
        [JsonProperty("backordered")]
        public bool Backordered { get; set; }
        [JsonProperty("weight")]
        public string Weight { get; set; }
        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }
        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }
        [JsonProperty("shipping_class_id")]
        public int ShippingClassId { get; set; }
        [JsonProperty("cross_sell_ids")]
        public IList<CrossSellIds> CrossSellIds { get; set; }
        [JsonProperty("categories")]
        public IList<Categories> Categories { get; set; }
        [JsonProperty("tags")]
        public IList<Tags> Tags { get; set; }
        [JsonProperty("images")]
        public IList<Images> Images { get; set; }
        [JsonProperty("attributes")]
        public IList<Attributes> Attributes { get; set; }
        [JsonProperty("default_attributes")]
        public IList<DefaultAttributes> DefaultAttributes { get; set; }
        [JsonProperty("variations")]
        public IList<Variations> Variations { get; set; }
        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }
        [JsonProperty("composite_layout")]
        public string CompositeLayout { get; set; }
        [JsonProperty("composite_components")]
        public IList<CompositeComponents> CompositeComponents { get; set; }
        [JsonProperty("composite_scenarios")]
        public IList<CompositeScenarios> CompositeScenarios { get; set; }
        [JsonProperty("bundle_layout")]
        public string BundleLayout { get; set; }
        //[JsonProperty("bundled_by")]
        //public IList<BundledBy> BundledBys { get; set; }
        [JsonProperty("bundled_items")]
        public IList<BundledItems> BundledItems { get; set; }
        [JsonProperty("mixed_sku_volume_pricing_group")]
        public MixedSkuVolumePricingGroup MixedSkuVolumePricingGroup { get; set; }
        [JsonProperty("custom_fields")]
        public CustomFields CustomFields { get; set; }
        [JsonProperty("pricing_groups")]
        public IList<PricingGroups> PricingGroups { get; set; }
        [JsonProperty("composite_product_details")]
        public object CompositeProductDetails { get; set; }
        [JsonProperty("bundle_product_details")]
        public object BundleProductDetails { get; set; }
        [JsonProperty("group_of")]
        public int GroupOf { get; set; }
        [JsonProperty("minimum_quantity")]
        public object MinimumQuantity { get; set; }
        [JsonProperty("maximum_quantity")]
        public object MaximumQuantity { get; set; }
        [JsonProperty("insurance_class")]
        public string InsuranceClass { get; set; }
        [JsonProperty("insurance_class_id")]
        public object InsuranceClassId { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
        [JsonProperty("bulk_variation_input")]
        public BulkVariationInput BulkVariationInput { get; set; }
    }

    public class Dimensions
    {
        [JsonProperty("length")]
        public string Length { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
    }

    public class CrossSellIds
    {

    }

    public class Categories
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class Tags
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class Images
    {
        [JsonProperty("src")]
        public string Src { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("src_small")]
        public string SrcSmall { get; set; }
        [JsonProperty("src_medium")]
        public string SrcMedium { get; set; }
        [JsonProperty("src_large")]
        public string SrcLarge { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("alt")]
        public string Alt { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("variation")]
        public bool Variation { get; set; }
        [JsonProperty("options")]
        public IList<string> Options { get; set; }
        [JsonProperty("option")]
        public string Option { get; set; }
    }

    public class DefaultAttributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("option")]
        public string Option { get; set; }
    }

    public class Variations
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("regular_price")]
        public string RegularPrice { get; set; }
        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }
        [JsonProperty("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }
        [JsonProperty("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }
        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }
        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; }
        [JsonProperty("stock_quantity")]
        public double? StockQuantity { get; set; }
        [JsonProperty("in_stock")]
        public bool InStock { get; set; }
        [JsonProperty("backorders")]
        public string Backorders { get; set; }
        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }
        [JsonProperty("backordered")]
        public bool Backordered { get; set; }
        [JsonProperty("weight")]
        public string Weight { get; set; }
        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }
        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }
        [JsonProperty("shipping_class_id")]
        public int ShippingClassId { get; set; }
        [JsonProperty("image")]
        public IList<Image> Images { get; set; }
        [JsonProperty("attributes")]
        public IList<Attributes> Attributes { get; set; }
        [JsonProperty("custom_fields")]
        public CustomFields CustomFields { get; set; }
        [JsonProperty("points_earned")]
        public string PointsEarned { get; set; }
        [JsonProperty("points_required")]
        public string PointsRequired { get; set; }
        [JsonProperty("maximum_points_discount")]
        public string MaximumPointsDiscount { get; set; }
        [JsonProperty("insurance_class")]
        public string InsuranceClass { get; set; }
        [JsonProperty("insurance_class_id")]
        public object InsuranceClassId { get; set; }
        [JsonProperty("inventory")]
        public IList<Inventory> Inventorys { get; set; }
    }

    public class Image
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("src")]
        public string Src { get; set; }
        [JsonProperty("alt")]
        public string Alt { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("src_small")]
        public string SrcSmall { get; set; }
        [JsonProperty("src_medium")]
        public string SrcMedium { get; set; }
        [JsonProperty("src_large")]
        public string SrcLarge { get; set; }
    }

    public class CustomFields
    {
        [JsonProperty("to_hide")]
        public string ToHide { get; set; }
        [JsonProperty("cost")]
        public object Cost { get; set; }
        [JsonProperty("customer_tiers_on_sale")]
        public string CustomerTiersOnSale { get; set; }
        [JsonProperty("variation_barcode")]
        public string VariationBarcode { get; set; }
        [JsonProperty("variation_shelf")]
        public string VariationShelf { get; set; }
        [JsonProperty("minprice")]
        public object Minprice { get; set; }
        [JsonProperty("conversionrategroup")]
        public string Conversionrategroup { get; set; }
        [JsonProperty("conversionrate")]
        public object Conversionrate { get; set; }
        [JsonProperty("sales_item")]
        public string SalesItem { get; set; }
        [JsonProperty("internal_sales_item")]
        public string InternalSalesItem { get; set; }
        [JsonProperty("inventory_item")]
        public string InventoryItem { get; set; }
        [JsonProperty("to_hide_during_picking_and_packing")]
        public string ToHideDuringPickingAndPacking { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("disallow_children_backorders")]
        public string DisallowChildrenBackorders { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("date_valid_from")]
        public string DateValidFrom { get; set; }
        [JsonProperty("date_valid_to")]
        public string DateValidTo { get; set; }
        [JsonProperty("internal_description")]
        public string InternalDescription { get; set; }
        [JsonProperty("discontinued")]
        public string Discontinued { get; set; }
        [JsonProperty("customer_tiers")]
        public string CustomerTiers { get; set; }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("is_rack_barcode")]
        public string IsRackBarcode { get; set; }
        [JsonProperty("customers")]
        public string Customers { get; set; }
        [JsonProperty("price_tags")]
        public string PriceTags { get; set; }
    }

    public class Inventory
    {
        [JsonProperty("branch_id")]
        public int BranchId { get; set; }
        [JsonProperty("batch_id")]
        public object BatchId { get; set; }
        [JsonProperty("stock_quantity")]
        public double? StockQuantity { get; set; }
        [JsonProperty("physical_stock_quantity")]
        public double? PhysicalStockQuantity { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CompositeComponents
    {

    }

    public class CompositeScenarios
    {

    }

    public class BundledBy
    {

    }

    public class BundledItems
    {

    }

    public class MixedSkuVolumePricingGroup
    {
        [JsonProperty("product_ids")]
        public IList<ProductIds> ProductIds { get; set; }
        [JsonProperty("product_attributes")]
        public IList<ProductAttributes> ProductAttributes { get; set; }
    }

    public class ProductIds
    {

    }

    public class ProductAttributes
    {

    }

    public class PricingGroups
    {

    }

    public class Links
    {
        [JsonProperty("self")]
        public IList<Self> Selfs { get; set; }
        [JsonProperty("collection")]
        public IList<Collection> Collections { get; set; }
    }

    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Collection
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class BulkVariationInput
    {
        [JsonProperty("bulk_variation_form")]
        public bool BulkVariationForm { get; set; }
        [JsonProperty("single_variation_form")]
        public bool SingleVariationForm { get; set; }
        [JsonProperty("columns")]
        public string Columns { get; set; }
        [JsonProperty("rows")]
        public string Rows { get; set; }
    }
}
