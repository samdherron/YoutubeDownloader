
namespace YoutubeDownloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrl = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.tabControlAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(998, 483);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(998, 483);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta);
            this.tabControlAdv1.ThemeName = "TabRendererDockingWhidbeyBeta";
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.ThemeStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.ThemeStyle.TabStyle.InactiveFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv1.Controls.Add(this.listView1);
            this.tabPageAdv1.Controls.Add(this.gradientLabel1);
            this.tabPageAdv1.Controls.Add(this.txtUrl);
            this.tabPageAdv1.Controls.Add(this.sfButton1);
            this.tabPageAdv1.Controls.Add(this.progressBarAdv1);
            this.tabPageAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(3, 35);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(991, 443);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Downloads";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv2.Location = new System.Drawing.Point(3, 35);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(991, 443);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Settings";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // designTimeTabTypeLoader
            // 
            this.designTimeTabTypeLoader.InvokeMemberName = "TabStyleName";
            // 
            // flowLayout1
            // 
            this.flowLayout1.ContainerControl = this.tabPageAdv1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Length,
            this.Size});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(992, 326);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Length
            // 
            this.Length.Text = "Length";
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSuggestFormula = false;
            this.txtUrl.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.Location = new System.Drawing.Point(12, 362);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(886, 22);
            this.txtUrl.TabIndex = 1;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.PaleVioletRed, System.Drawing.Color.Crimson);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(195, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientLabel1.Location = new System.Drawing.Point(398, 331);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(195, 23);
            this.gradientLabel1.TabIndex = 2;
            this.gradientLabel1.Text = "Video URL:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.Color.DimGray;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(903, 359);
            this.sfButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(75, 28);
            this.sfButton1.Style.BackColor = System.Drawing.Color.DimGray;
            this.sfButton1.TabIndex = 3;
            this.sfButton1.Text = "Go";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016Colorful;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.FontColor = System.Drawing.Color.Black;
            this.progressBarAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.LightGreen;
            this.progressBarAdv1.Location = new System.Drawing.Point(295, 392);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(400, 23);
            this.progressBarAdv1.TabIndex = 4;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.ThemeName = "Gradient";
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.Visible = false;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 483);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "MainForm";
            this.Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Size;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtUrl;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
    }
}

