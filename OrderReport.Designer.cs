namespace Login
{
    partial class OrderReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group3 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group4 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group5 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group6 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group7 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.customerNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dressSelectionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.quantityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.orderDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.deliveryDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.customerNameGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.customerNameGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.dressSelectionGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.dressSelectionGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.quantityGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.quantityGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.totalPriceGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.totalPriceGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.orderDateGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.orderDateGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.deliveryDateGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.deliveryDateGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
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
            this.sqlDataSource1.SelectCommand = "SELECT        Orders.*\r\nFROM            Orders";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.customerNameCaptionTextBox,
            this.dressSelectionCaptionTextBox,
            this.quantityCaptionTextBox,
            this.totalPriceCaptionTextBox,
            this.orderDateCaptionTextBox,
            this.deliveryDateCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // customerNameCaptionTextBox
            // 
            this.customerNameCaptionTextBox.CanGrow = true;
            this.customerNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.customerNameCaptionTextBox.Name = "customerNameCaptionTextBox";
            this.customerNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.customerNameCaptionTextBox.StyleName = "Caption";
            this.customerNameCaptionTextBox.Value = "Customer Name";
            // 
            // dressSelectionCaptionTextBox
            // 
            this.dressSelectionCaptionTextBox.CanGrow = true;
            this.dressSelectionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.094D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.dressSelectionCaptionTextBox.Name = "dressSelectionCaptionTextBox";
            this.dressSelectionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.dressSelectionCaptionTextBox.StyleName = "Caption";
            this.dressSelectionCaptionTextBox.Value = "Dress Selection";
            // 
            // quantityCaptionTextBox
            // 
            this.quantityCaptionTextBox.CanGrow = true;
            this.quantityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.quantityCaptionTextBox.Name = "quantityCaptionTextBox";
            this.quantityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityCaptionTextBox.StyleName = "Caption";
            this.quantityCaptionTextBox.Value = "Quantity";
            // 
            // totalPriceCaptionTextBox
            // 
            this.totalPriceCaptionTextBox.CanGrow = true;
            this.totalPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.24D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.totalPriceCaptionTextBox.Name = "totalPriceCaptionTextBox";
            this.totalPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalPriceCaptionTextBox.StyleName = "Caption";
            this.totalPriceCaptionTextBox.Value = "Total Price";
            // 
            // orderDateCaptionTextBox
            // 
            this.orderDateCaptionTextBox.CanGrow = true;
            this.orderDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.orderDateCaptionTextBox.Name = "orderDateCaptionTextBox";
            this.orderDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.orderDateCaptionTextBox.StyleName = "Caption";
            this.orderDateCaptionTextBox.Value = "Order Date";
            // 
            // deliveryDateCaptionTextBox
            // 
            this.deliveryDateCaptionTextBox.CanGrow = true;
            this.deliveryDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.385D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.deliveryDateCaptionTextBox.Name = "deliveryDateCaptionTextBox";
            this.deliveryDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.deliveryDateCaptionTextBox.StyleName = "Caption";
            this.deliveryDateCaptionTextBox.Value = "Delivery Date";
            // 
            // customerNameGroupHeaderSection
            // 
            this.customerNameGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.customerNameGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.textBox6});
            this.customerNameGroupHeaderSection.Name = "customerNameGroupHeaderSection";
            // 
            // customerNameGroupFooterSection
            // 
            this.customerNameGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.customerNameGroupFooterSection.Name = "customerNameGroupFooterSection";
            // 
            // dressSelectionGroupHeaderSection
            // 
            this.dressSelectionGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.dressSelectionGroupHeaderSection.Name = "dressSelectionGroupHeaderSection";
            // 
            // dressSelectionGroupFooterSection
            // 
            this.dressSelectionGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.dressSelectionGroupFooterSection.Name = "dressSelectionGroupFooterSection";
            // 
            // quantityGroupHeaderSection
            // 
            this.quantityGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.quantityGroupHeaderSection.Name = "quantityGroupHeaderSection";
            // 
            // quantityGroupFooterSection
            // 
            this.quantityGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.quantityGroupFooterSection.Name = "quantityGroupFooterSection";
            // 
            // totalPriceGroupHeaderSection
            // 
            this.totalPriceGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.totalPriceGroupHeaderSection.Name = "totalPriceGroupHeaderSection";
            // 
            // totalPriceGroupFooterSection
            // 
            this.totalPriceGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.totalPriceGroupFooterSection.Name = "totalPriceGroupFooterSection";
            // 
            // orderDateGroupHeaderSection
            // 
            this.orderDateGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.orderDateGroupHeaderSection.Name = "orderDateGroupHeaderSection";
            // 
            // orderDateGroupFooterSection
            // 
            this.orderDateGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.orderDateGroupFooterSection.Name = "orderDateGroupFooterSection";
            // 
            // deliveryDateGroupHeaderSection
            // 
            this.deliveryDateGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.deliveryDateGroupHeaderSection.Name = "deliveryDateGroupHeaderSection";
            // 
            // deliveryDateGroupFooterSection
            // 
            this.deliveryDateGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.deliveryDateGroupFooterSection.Name = "deliveryDateGroupFooterSection";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "= Fields.CustomerName";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.073D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.DressSelection";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Fields.Quantity";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.24D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.TotalPrice";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "= Fields.OrderDate";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.385D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "= Fields.DeliveryDate";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8D), Telerik.Reporting.Drawing.Unit.Inch(0.469D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "OrderReport";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Name = "detail";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6D), Telerik.Reporting.Drawing.Unit.Inch(0.6D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.StyleName = "Caption";
            this.textBox10.Value = "Telephone : 077 1234567 , 075 7654321";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8D), Telerik.Reporting.Drawing.Unit.Inch(0.6D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Main Street, Kalmunai";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6D), Telerik.Reporting.Drawing.Unit.Inch(0.384D));
            this.textBox8.StyleName = "Title";
            this.textBox8.Value = "ASH Bridals";
            // 
            // OrderReport
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.customerNameGroupFooterSection;
            group2.GroupHeader = this.customerNameGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.CustomerName"));
            group2.Name = "customerNameGroup";
            group3.GroupFooter = this.dressSelectionGroupFooterSection;
            group3.GroupHeader = this.dressSelectionGroupHeaderSection;
            group3.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.DressSelection"));
            group3.Name = "dressSelectionGroup";
            group4.GroupFooter = this.quantityGroupFooterSection;
            group4.GroupHeader = this.quantityGroupHeaderSection;
            group4.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Quantity"));
            group4.Name = "quantityGroup";
            group5.GroupFooter = this.totalPriceGroupFooterSection;
            group5.GroupHeader = this.totalPriceGroupHeaderSection;
            group5.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.TotalPrice"));
            group5.Name = "totalPriceGroup";
            group6.GroupFooter = this.orderDateGroupFooterSection;
            group6.GroupHeader = this.orderDateGroupHeaderSection;
            group6.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.OrderDate"));
            group6.Name = "orderDateGroup";
            group7.GroupFooter = this.deliveryDateGroupFooterSection;
            group7.GroupHeader = this.deliveryDateGroupHeaderSection;
            group7.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.DeliveryDate"));
            group7.Name = "deliveryDateGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2,
            group3,
            group4,
            group5,
            group6,
            group7});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.customerNameGroupHeaderSection,
            this.customerNameGroupFooterSection,
            this.dressSelectionGroupHeaderSection,
            this.dressSelectionGroupFooterSection,
            this.quantityGroupHeaderSection,
            this.quantityGroupFooterSection,
            this.totalPriceGroupHeaderSection,
            this.totalPriceGroupFooterSection,
            this.orderDateGroupHeaderSection,
            this.orderDateGroupFooterSection,
            this.deliveryDateGroupHeaderSection,
            this.deliveryDateGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "OrderReport";
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
        private Telerik.Reporting.TextBox customerNameCaptionTextBox;
        private Telerik.Reporting.TextBox dressSelectionCaptionTextBox;
        private Telerik.Reporting.TextBox quantityCaptionTextBox;
        private Telerik.Reporting.TextBox totalPriceCaptionTextBox;
        private Telerik.Reporting.TextBox orderDateCaptionTextBox;
        private Telerik.Reporting.TextBox deliveryDateCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection customerNameGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.GroupFooterSection customerNameGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection dressSelectionGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection dressSelectionGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection quantityGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.GroupFooterSection quantityGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection totalPriceGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.GroupFooterSection totalPriceGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection orderDateGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.GroupFooterSection orderDateGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection deliveryDateGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.GroupFooterSection deliveryDateGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
    }
}