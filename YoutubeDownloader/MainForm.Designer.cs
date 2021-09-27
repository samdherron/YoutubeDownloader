
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
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.txtUrl = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.youtubeVideoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideoInfoBindingSource)).BeginInit();
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
            this.tabPageAdv1.Controls.Add(this.listBox1);
            this.tabPageAdv1.Controls.Add(this.gradientLabel1);
            this.tabPageAdv1.Controls.Add(this.txtUrl);
            this.tabPageAdv1.Controls.Add(this.sfButton1);
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
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.PaleVioletRed, System.Drawing.Color.Crimson);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(195, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientLabel1.Location = new System.Drawing.Point(398, 377);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(195, 23);
            this.gradientLabel1.TabIndex = 2;
            this.gradientLabel1.Text = "Video URL:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSuggestFormula = false;
            this.txtUrl.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.Location = new System.Drawing.Point(12, 408);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(886, 22);
            this.txtUrl.TabIndex = 1;
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.Color.DimGray;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(903, 405);
            this.sfButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(75, 28);
            this.sfButton1.Style.BackColor = System.Drawing.Color.DimGray;
            this.sfButton1.TabIndex = 3;
            this.sfButton1.Text = "Go";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
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
            // youtubeVideoInfoBindingSource
            // 
            this.youtubeVideoInfoBindingSource.DataSource = typeof(YoutubeDownloader.Models.YoutubeVideoInfo);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(988, 372);
            this.listBox1.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideoInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtUrl;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.BindingSource youtubeVideoInfoBindingSource;
        private System.Windows.Forms.ListBox listBox1;
    }
}

