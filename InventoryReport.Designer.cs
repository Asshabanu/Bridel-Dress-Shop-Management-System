namespace Login
{
    partial class InventoryReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.brandCaptionTextBox = new Telerik.Reporting.TextBox();
            this.categoryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.finalPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.costPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.itemNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.locationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.quantityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.supplierNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.discountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.brandDataTextBox = new Telerik.Reporting.TextBox();
            this.categoryDataTextBox = new Telerik.Reporting.TextBox();
            this.finalPriceDataTextBox = new Telerik.Reporting.TextBox();
            this.costPriceDataTextBox = new Telerik.Reporting.TextBox();
            this.itemNameDataTextBox = new Telerik.Reporting.TextBox();
            this.locationDataTextBox = new Telerik.Reporting.TextBox();
            this.quantityDataTextBox = new Telerik.Reporting.TextBox();
            this.supplierNameDataTextBox = new Telerik.Reporting.TextBox();
            this.discountDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Data Source=DESKTOP-JBANP1R;Initial Catalog=bridal_shop;Integrated Security=True;" +
    "Encrypt=True;TrustServerCertificate=True";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.ProviderName = "System.Data.SqlClient";
            this.sqlDataSource1.SelectCommand = "SELECT        Inventory.*\r\nFROM            Inventory";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.brandCaptionTextBox,
            this.categoryCaptionTextBox,
            this.costPriceCaptionTextBox,
            this.locationCaptionTextBox,
            this.quantityCaptionTextBox,
            this.supplierNameCaptionTextBox,
            this.discountCaptionTextBox,
            this.finalPriceCaptionTextBox,
            this.itemNameCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // brandCaptionTextBox
            // 
            this.brandCaptionTextBox.CanGrow = true;
            this.brandCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.778D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.brandCaptionTextBox.Name = "brandCaptionTextBox";
            this.brandCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.brandCaptionTextBox.StyleName = "Caption";
            this.brandCaptionTextBox.Value = "Brand";
            // 
            // categoryCaptionTextBox
            // 
            this.categoryCaptionTextBox.CanGrow = true;
            this.categoryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.472D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.categoryCaptionTextBox.Name = "categoryCaptionTextBox";
            this.categoryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.categoryCaptionTextBox.StyleName = "Caption";
            this.categoryCaptionTextBox.Value = "Category";
            // 
            // finalPriceCaptionTextBox
            // 
            this.finalPriceCaptionTextBox.CanGrow = true;
            this.finalPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.945D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.finalPriceCaptionTextBox.Name = "finalPriceCaptionTextBox";
            this.finalPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.finalPriceCaptionTextBox.StyleName = "Caption";
            this.finalPriceCaptionTextBox.Value = "Final Price";
            // 
            // costPriceCaptionTextBox
            // 
            this.costPriceCaptionTextBox.CanGrow = true;
            this.costPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.556D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.costPriceCaptionTextBox.Name = "costPriceCaptionTextBox";
            this.costPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.costPriceCaptionTextBox.StyleName = "Caption";
            this.costPriceCaptionTextBox.Value = "Cost Price";
            // 
            // itemNameCaptionTextBox
            // 
            this.itemNameCaptionTextBox.CanGrow = true;
            this.itemNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.084D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemNameCaptionTextBox.Name = "itemNameCaptionTextBox";
            this.itemNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemNameCaptionTextBox.StyleName = "Caption";
            this.itemNameCaptionTextBox.Value = "Item Name";
            // 
            // locationCaptionTextBox
            // 
            this.locationCaptionTextBox.CanGrow = true;
            this.locationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.locationCaptionTextBox.Name = "locationCaptionTextBox";
            this.locationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.locationCaptionTextBox.StyleName = "Caption";
            this.locationCaptionTextBox.Value = "Location";
            // 
            // quantityCaptionTextBox
            // 
            this.quantityCaptionTextBox.CanGrow = true;
            this.quantityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.861D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.quantityCaptionTextBox.Name = "quantityCaptionTextBox";
            this.quantityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityCaptionTextBox.StyleName = "Caption";
            this.quantityCaptionTextBox.Value = "Quantity";
            // 
            // supplierNameCaptionTextBox
            // 
            this.supplierNameCaptionTextBox.CanGrow = true;
            this.supplierNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.639D), Telerik.Reporting.Drawing.Unit.Inch(0.011D));
            this.supplierNameCaptionTextBox.Name = "supplierNameCaptionTextBox";
            this.supplierNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.supplierNameCaptionTextBox.StyleName = "Caption";
            this.supplierNameCaptionTextBox.Value = "Supplier Name";
            // 
            // discountCaptionTextBox
            // 
            this.discountCaptionTextBox.CanGrow = true;
            this.discountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.25D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.discountCaptionTextBox.Name = "discountCaptionTextBox";
            this.discountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.discountCaptionTextBox.StyleName = "Caption";
            this.discountCaptionTextBox.Value = "Discount";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.9D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8,
            this.textBox9,
            this.textBox10});
            this.pageHeader.Name = "pageHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.24D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.219D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.487D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0.019D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.333D), Telerik.Reporting.Drawing.Unit.Inch(0.469D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "InventoryReport";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.brandDataTextBox,
            this.categoryDataTextBox,
            this.itemNameDataTextBox,
            this.locationDataTextBox,
            this.quantityDataTextBox,
            this.finalPriceDataTextBox,
            this.costPriceDataTextBox,
            this.discountDataTextBox,
            this.supplierNameDataTextBox});
            this.detail.Name = "detail";
            // 
            // brandDataTextBox
            // 
            this.brandDataTextBox.CanGrow = true;
            this.brandDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.778D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.brandDataTextBox.Name = "brandDataTextBox";
            this.brandDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.brandDataTextBox.StyleName = "Data";
            this.brandDataTextBox.Value = "= Fields.Brand";
            // 
            // categoryDataTextBox
            // 
            this.categoryDataTextBox.CanGrow = true;
            this.categoryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.472D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.categoryDataTextBox.Name = "categoryDataTextBox";
            this.categoryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.categoryDataTextBox.StyleName = "Data";
            this.categoryDataTextBox.Value = "= Fields.Category";
            // 
            // finalPriceDataTextBox
            // 
            this.finalPriceDataTextBox.CanGrow = true;
            this.finalPriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.945D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.finalPriceDataTextBox.Name = "finalPriceDataTextBox";
            this.finalPriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.finalPriceDataTextBox.StyleName = "Data";
            this.finalPriceDataTextBox.Value = "= Fields.FinalPrice";
            // 
            // costPriceDataTextBox
            // 
            this.costPriceDataTextBox.CanGrow = true;
            this.costPriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.556D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.costPriceDataTextBox.Name = "costPriceDataTextBox";
            this.costPriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.costPriceDataTextBox.StyleName = "Data";
            this.costPriceDataTextBox.Value = "= Fields.CostPrice";
            // 
            // itemNameDataTextBox
            // 
            this.itemNameDataTextBox.CanGrow = true;
            this.itemNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.084D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemNameDataTextBox.Name = "itemNameDataTextBox";
            this.itemNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemNameDataTextBox.StyleName = "Data";
            this.itemNameDataTextBox.Value = "= Fields.ItemName";
            // 
            // locationDataTextBox
            // 
            this.locationDataTextBox.CanGrow = true;
            this.locationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.locationDataTextBox.Name = "locationDataTextBox";
            this.locationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.locationDataTextBox.StyleName = "Data";
            this.locationDataTextBox.Value = "= Fields.Location";
            // 
            // quantityDataTextBox
            // 
            this.quantityDataTextBox.CanGrow = true;
            this.quantityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.861D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.quantityDataTextBox.Name = "quantityDataTextBox";
            this.quantityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityDataTextBox.StyleName = "Data";
            this.quantityDataTextBox.Value = "= Fields.Quantity";
            // 
            // supplierNameDataTextBox
            // 
            this.supplierNameDataTextBox.CanGrow = true;
            this.supplierNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.639D), Telerik.Reporting.Drawing.Unit.Inch(0.03D));
            this.supplierNameDataTextBox.Name = "supplierNameDataTextBox";
            this.supplierNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.supplierNameDataTextBox.StyleName = "Data";
            this.supplierNameDataTextBox.Value = "= Fields.SupplierName";
            // 
            // discountDataTextBox
            // 
            this.discountDataTextBox.CanGrow = true;
            this.discountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.25D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.discountDataTextBox.Name = "discountDataTextBox";
            this.discountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.discountDataTextBox.StyleName = "Data";
            this.discountDataTextBox.Value = "= Fields.Discount";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.729D), Telerik.Reporting.Drawing.Unit.Inch(0.55D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.StyleName = "Caption";
            this.textBox10.Value = "Telephone : 077 1234567 , 075 7654321";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.929D), Telerik.Reporting.Drawing.Unit.Inch(0.55D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Main Street, Kalmunai";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.729D), Telerik.Reporting.Drawing.Unit.Inch(0.15D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.384D));
            this.textBox8.StyleName = "Title";
            this.textBox8.Value = "ASH Bridals";
            // 
            // InventoryReport
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "InventoryReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption"),
            new Telerik.Reporting.Drawing.StyleSelector("SubTotalCaption"),
            new Telerik.Reporting.Drawing.StyleSelector("GrandTotalCaption")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data"),
            new Telerik.Reporting.Drawing.StyleSelector("TotalData")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.458D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox brandCaptionTextBox;
        private Telerik.Reporting.TextBox categoryCaptionTextBox;
        private Telerik.Reporting.TextBox finalPriceCaptionTextBox;
        private Telerik.Reporting.TextBox costPriceCaptionTextBox;
        private Telerik.Reporting.TextBox itemNameCaptionTextBox;
        private Telerik.Reporting.TextBox locationCaptionTextBox;
        private Telerik.Reporting.TextBox quantityCaptionTextBox;
        private Telerik.Reporting.TextBox supplierNameCaptionTextBox;
        private Telerik.Reporting.TextBox discountCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox brandDataTextBox;
        private Telerik.Reporting.TextBox categoryDataTextBox;
        private Telerik.Reporting.TextBox finalPriceDataTextBox;
        private Telerik.Reporting.TextBox costPriceDataTextBox;
        private Telerik.Reporting.TextBox itemNameDataTextBox;
        private Telerik.Reporting.TextBox locationDataTextBox;
        private Telerik.Reporting.TextBox quantityDataTextBox;
        private Telerik.Reporting.TextBox supplierNameDataTextBox;
        private Telerik.Reporting.TextBox discountDataTextBox;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
    }
}