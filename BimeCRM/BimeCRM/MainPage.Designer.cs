namespace BimeCRM
{
    partial class MainPage
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuBimeAll = new Telerik.WinControls.UI.RadMenuItem();
            this.menuBimeSales = new Telerik.WinControls.UI.RadMenuItem();
            this.menuBimeBadane = new Telerik.WinControls.UI.RadMenuItem();
            this.menuBimeOthers = new Telerik.WinControls.UI.RadMenuItem();
            this.menuPersons = new Telerik.WinControls.UI.RadMenuItem();
            this.menuInfo = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuDatacenter = new Telerik.WinControls.UI.RadMenuItem();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.mainPageView = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.menuPersons,
            this.menuInfo,
            this.menuDatacenter});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radMenu1.Size = new System.Drawing.Size(1120, 35);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.ThemeName = "VisualStudio2012Light";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.CustomFontStyle = System.Drawing.FontStyle.Regular;
            this.radMenuItem1.Font = new System.Drawing.Font("B Titr", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuBimeAll,
            this.menuBimeSales,
            this.menuBimeBadane,
            this.menuBimeOthers});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.radMenuItem1.PopupDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radMenuItem1.RightToLeft = true;
            this.radMenuItem1.ShowArrow = true;
            this.radMenuItem1.Text = "بیمه ها";
            // 
            // menuBimeAll
            // 
            this.menuBimeAll.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.menuBimeAll.Name = "menuBimeAll";
            this.menuBimeAll.Text = "همه";
            this.menuBimeAll.Click += new System.EventHandler(this.menuBimeAll_Click);
            // 
            // menuBimeSales
            // 
            this.menuBimeSales.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.menuBimeSales.Name = "menuBimeSales";
            this.menuBimeSales.Text = "ثالث";
            this.menuBimeSales.Click += new System.EventHandler(this.menuBimeSales_Click);
            // 
            // menuBimeBadane
            // 
            this.menuBimeBadane.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.menuBimeBadane.Name = "menuBimeBadane";
            this.menuBimeBadane.Text = "بدنه";
            this.menuBimeBadane.Click += new System.EventHandler(this.menuBimeBadane_Click);
            // 
            // menuBimeOthers
            // 
            this.menuBimeOthers.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.menuBimeOthers.Name = "menuBimeOthers";
            this.menuBimeOthers.Text = "سایر";
            this.menuBimeOthers.Click += new System.EventHandler(this.menuBimeOthers_Click);
            // 
            // menuPersons
            // 
            this.menuPersons.Font = new System.Drawing.Font("B Titr", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuPersons.Name = "menuPersons";
            this.menuPersons.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.menuPersons.PopupDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.menuPersons.RightToLeft = true;
            this.menuPersons.Text = "بیمه گذاران";
            this.menuPersons.Click += new System.EventHandler(this.menuPersons_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Font = new System.Drawing.Font("B Titr", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuInfo.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem9,
            this.radMenuItem10});
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.menuInfo.PopupDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.menuInfo.RightToLeft = true;
            this.menuInfo.ShowArrow = true;
            this.menuInfo.Text = "اطلاعات";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "کامنت بیمه";
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "کامنت اشخاص";
            // 
            // menuDatacenter
            // 
            this.menuDatacenter.Font = new System.Drawing.Font("B Titr", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuDatacenter.Name = "menuDatacenter";
            this.menuDatacenter.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.menuDatacenter.PopupDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.menuDatacenter.RightToLeft = true;
            this.menuDatacenter.Text = "دیتا سنتر";
            this.menuDatacenter.Click += new System.EventHandler(this.menuDatacenter_Click);
            // 
            // mainPageView
            // 
            this.mainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageView.Location = new System.Drawing.Point(0, 35);
            this.mainPageView.Name = "mainPageView";
            this.mainPageView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainPageView.Size = new System.Drawing.Size(1120, 663);
            this.mainPageView.TabIndex = 1;
            this.mainPageView.ThemeName = "VisualStudio2012Light";
            this.mainPageView.PageRemoved += new System.EventHandler<Telerik.WinControls.UI.RadPageViewEventArgs>(this.mainPageView_PageRemoved);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.LeftScroll;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).ItemFitMode = ((Telerik.WinControls.UI.StripViewItemFitMode)((Telerik.WinControls.UI.StripViewItemFitMode.Shrink | Telerik.WinControls.UI.StripViewItemFitMode.Fill)));
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 698);
            this.Controls.Add(this.mainPageView);
            this.Controls.Add(this.radMenu1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem menuBimeAll;
        private Telerik.WinControls.UI.RadMenuItem menuBimeSales;
        private Telerik.WinControls.UI.RadMenuItem menuBimeBadane;
        private Telerik.WinControls.UI.RadMenuItem menuBimeOthers;
        private Telerik.WinControls.UI.RadMenuItem menuPersons;
        private Telerik.WinControls.UI.RadMenuItem menuInfo;
        private Telerik.WinControls.UI.RadMenuItem menuDatacenter;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPageView mainPageView;
    }
}