using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.IsWindowLess = false;
            this.chartControl1.Title.Text = "Product Sales";
            this.chartControl1.Size = new System.Drawing.Size(457, 330);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.Skins = Skins.Metro;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Tooltip.BackgroundColor = new BrushInfo(Color.White);
            this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            this.chartControl1.Tooltip.Font = new Font("Segoe UI", 10);
            
            // 
            // Legend
            // 
            this.chartControl1.Legend.Visible = true;
            this.chartControl1.LegendAlignment = ChartAlignment.Center;
            this.chartControl1.Legend.Position = ChartDock.Top;
            this.chartControl1.LegendsPlacement = ChartPlacement.Outside;
            this.chartControl1.Legend.Location = new System.Drawing.Point(321, 87);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(174, 87);
            //
            // PrimaryXAxis
            //
            this.chartControl1.PrimaryXAxis.Title = "Year";
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            //
            // PrimaryYAxis
            //
            this.chartControl1.PrimaryYAxis.Title = "Sales(Millions)";
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            // 
            // Form1
            // 
            BindingList<SalesData> dataSource = new BindingList<SalesData>();
            dataSource.Add(new SalesData("1999", 5));
            dataSource.Add(new SalesData("2000", 7));
            dataSource.Add(new SalesData("2001", 12));
            dataSource.Add(new SalesData("2002", 18));
            dataSource.Add(new SalesData("2003", 22));
            dataSource.Add(new SalesData("2004", 30));
            dataSource.Add(new SalesData("2005", 40));
            dataSource.Add(new SalesData("2006", 50));
            dataSource.Add(new SalesData("2007", 65));
            dataSource.Add(new SalesData("2008", 75));

            CategoryAxisDataBindModel dataSeriesModel = new CategoryAxisDataBindModel(dataSource);
            dataSeriesModel.CategoryName = "Year";
            dataSeriesModel.YNames = new string[] { "Sales" };

            var template = new ChartTemplate(typeof(ChartControl));
            template.Scan(this.chartControl1);
            template.Save("TemplateName.xml");

            //ChartTemplate.Save(this.chartControl1, "TemplateName.xml");

            chartSeries1 = new ChartSeries("Sales");
            chartSeries1.PointsToolTipFormat = "{2}";
            chartSeries1.PrepareStyle += ChartSeries1_PrepareStyle;
            chartSeries1.CategoryModel = dataSeriesModel;
            chartSeries1.Style.DisplayText = true;
            chartSeries1.Style.TextOrientation = ChartTextOrientation.Up;
            this.chartControl1.Dock = DockStyle.Fill;
            this.chartControl1.Series.Add(chartSeries1);
            
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Size = new System.Drawing.Size(600, 450);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 577);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        
        private void ChartSeries1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            int index = args.Index;
            ChartPoint point = series.Points[index];
            args.Style.ToolTip = "Product : " + point.Category + "\nSales : " + point.YValues[0];
        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private bool canStopTimer;
    }
}

