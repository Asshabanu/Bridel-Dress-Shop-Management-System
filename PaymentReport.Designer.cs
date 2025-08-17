namespace Login
{
    partial class PaymentReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReport));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.amountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.discountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.finalPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.guestNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.itemNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.qtyCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.amountDataTextBox = new Telerik.Reporting.TextBox();
            this.discountDataTextBox = new Telerik.Reporting.TextBox();
            this.finalPriceDataTextBox = new Telerik.Reporting.TextBox();
            this.guestNameDataTextBox = new Telerik.Reporting.TextBox();
            this.itemNameDataTextBox = new Telerik.Reporting.TextBox();
            this.qtyDataTextBox = new Telerik.Reporting.TextBox();
            this.totalDataTextBox = new Telerik.Reporting.TextBox();
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
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.69D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.guestNameCaptionTextBox,
            this.totalCaptionTextBox,
            this.itemNameCaptionTextBox,
            this.amountCaptionTextBox,
            this.qtyCaptionTextBox,
            this.discountCaptionTextBox,
            this.finalPriceCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.327D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // amountCaptionTextBox
            // 
            this.amountCaptionTextBox.CanGrow = true;
            this.amountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1D), Telerik.Reporting.Drawing.Unit.Inch(0.49D));
            this.amountCaptionTextBox.Name = "amountCaptionTextBox";
            this.amountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.amountCaptionTextBox.StyleName = "Caption";
            this.amountCaptionTextBox.Value = "Amount";
            // 
            // discountCaptionTextBox
            // 
            this.discountCaptionTextBox.CanGrow = true;
            this.discountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.668D), Telerik.Reporting.Drawing.Unit.Inch(0.469D));
            this.discountCaptionTextBox.Name = "discountCaptionTextBox";
            this.discountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.discountCaptionTextBox.StyleName = "Caption";
            this.discountCaptionTextBox.Value = "Discount";
            // 
            // finalPriceCaptionTextBox
            // 
            this.finalPriceCaptionTextBox.CanGrow = true;
            this.finalPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.452D), Telerik.Reporting.Drawing.Unit.Inch(0.469D));
            this.finalPriceCaptionTextBox.Name = "finalPriceCaptionTextBox";
            this.finalPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.finalPriceCaptionTextBox.StyleName = "Caption";
            this.finalPriceCaptionTextBox.Value = "Final Price";
            // 
            // guestNameCaptionTextBox
            // 
            this.guestNameCaptionTextBox.CanGrow = true;
            this.guestNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.316D), Telerik.Reporting.Drawing.Unit.Inch(0.49D));
            this.guestNameCaptionTextBox.Name = "guestNameCaptionTextBox";
            this.guestNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.guestNameCaptionTextBox.StyleName = "Caption";
            this.guestNameCaptionTextBox.Value = "Guest Name";
            // 
            // itemNameCaptionTextBox
            // 
            this.itemNameCaptionTextBox.CanGrow = true;
            this.itemNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.532D), Telerik.Reporting.Drawing.Unit.Inch(0.49D));
            this.itemNameCaptionTextBox.Name = "itemNameCaptionTextBox";
            this.itemNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemNameCaptionTextBox.StyleName = "Caption";
            this.itemNameCaptionTextBox.Value = "Item Name";
            // 
            // qtyCaptionTextBox
            // 
            this.qtyCaptionTextBox.CanGrow = true;
            this.qtyCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.884D), Telerik.Reporting.Drawing.Unit.Inch(0.469D));
            this.qtyCaptionTextBox.Name = "qtyCaptionTextBox";
            this.qtyCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.qtyCaptionTextBox.StyleName = "Caption";
            this.qtyCaptionTextBox.Value = "Qty";
            // 
            // totalCaptionTextBox
            // 
            this.totalCaptionTextBox.CanGrow = true;
            this.totalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.236D), Telerik.Reporting.Drawing.Unit.Inch(0.49D));
            this.totalCaptionTextBox.Name = "totalCaptionTextBox";
            this.totalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalCaptionTextBox.StyleName = "Caption";
            this.totalCaptionTextBox.Value = "Total";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.8D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.079D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.358D), Telerik.Reporting.Drawing.Unit.Inch(0.387D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "PaymentReport";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.302D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemNameDataTextBox,
            this.totalDataTextBox,
            this.guestNameDataTextBox,
            this.amountDataTextBox,
            this.qtyDataTextBox,
            this.discountDataTextBox,
            this.finalPriceDataTextBox});
            this.detail.Name = "detail";
            // 
            // amountDataTextBox
            // 
            this.amountDataTextBox.CanGrow = true;
            this.amountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.amountDataTextBox.Name = "amountDataTextBox";
            this.amountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.amountDataTextBox.StyleName = "Data";
            this.amountDataTextBox.Value = "= Fields.Amount";
            // 
            // discountDataTextBox
            // 
            this.discountDataTextBox.CanGrow = true;
            this.discountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.668D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.discountDataTextBox.Name = "discountDataTextBox";
            this.discountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.discountDataTextBox.StyleName = "Data";
            this.discountDataTextBox.Value = "= Fields.Discount";
            // 
            // finalPriceDataTextBox
            // 
            this.finalPriceDataTextBox.CanGrow = true;
            this.finalPriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.452D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.finalPriceDataTextBox.Name = "finalPriceDataTextBox";
            this.finalPriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.finalPriceDataTextBox.StyleName = "Data";
            this.finalPriceDataTextBox.Value = "= Fields.FinalPrice";
            // 
            // guestNameDataTextBox
            // 
            this.guestNameDataTextBox.CanGrow = true;
            this.guestNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.316D), Telerik.Reporting.Drawing.Unit.Inch(0.179D));
            this.guestNameDataTextBox.Name = "guestNameDataTextBox";
            this.guestNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.guestNameDataTextBox.StyleName = "Data";
            this.guestNameDataTextBox.Value = "= Fields.GuestName";
            // 
            // itemNameDataTextBox
            // 
            this.itemNameDataTextBox.CanGrow = true;
            this.itemNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.532D), Telerik.Reporting.Drawing.Unit.Inch(0.179D));
            this.itemNameDataTextBox.Name = "itemNameDataTextBox";
            this.itemNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemNameDataTextBox.StyleName = "Data";
            this.itemNameDataTextBox.Value = "= Fields.ItemName";
            // 
            // qtyDataTextBox
            // 
            this.qtyDataTextBox.CanGrow = true;
            this.qtyDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.884D), Telerik.Reporting.Drawing.Unit.Inch(0.179D));
            this.qtyDataTextBox.Name = "qtyDataTextBox";
            this.qtyDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.qtyDataTextBox.StyleName = "Data";
            this.qtyDataTextBox.Value = "= Fields.Qty";
            // 
            // totalDataTextBox
            // 
            this.totalDataTextBox.CanGrow = true;
            this.totalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.236D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalDataTextBox.Name = "totalDataTextBox";
            this.totalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.784D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalDataTextBox.StyleName = "Data";
            this.totalDataTextBox.Value = "= Fields.Total";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.729D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.StyleName = "Caption";
            this.textBox10.Value = "Telephone : 077 1234567 , 075 7654321";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.929D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Main Street, Kalmunai";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.729D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.384D));
            this.textBox8.StyleName = "Title";
            this.textBox8.Value = "ASH Bridals";
            // 
            // PaymentReport
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
            this.Name = "PaymentReport";
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
        private Telerik.Reporting.TextBox amountCaptionTextBox;
        private Telerik.Reporting.TextBox discountCaptionTextBox;
        private Telerik.Reporting.TextBox finalPriceCaptionTextBox;
        private Telerik.Reporting.TextBox guestNameCaptionTextBox;
        private Telerik.Reporting.TextBox itemNameCaptionTextBox;
        private Telerik.Reporting.TextBox qtyCaptionTextBox;
        private Telerik.Reporting.TextBox totalCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox amountDataTextBox;
        private Telerik.Reporting.TextBox discountDataTextBox;
        private Telerik.Reporting.TextBox finalPriceDataTextBox;
        private Telerik.Reporting.TextBox guestNameDataTextBox;
        private Telerik.Reporting.TextBox itemNameDataTextBox;
        private Telerik.Reporting.TextBox qtyDataTextBox;
        private Telerik.Reporting.TextBox totalDataTextBox;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
    }
}