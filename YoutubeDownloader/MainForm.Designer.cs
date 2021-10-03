
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
            this.sfListView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.txtUrl = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.AutoPlaySetting = new MetroFramework.Controls.MetroCheckBox();
            this.youtubeVideoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1151, 724);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1151, 724);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta);
            this.tabControlAdv1.ThemeName = "TabRendererDockingWhidbeyBeta";
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.ThemeStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.tabControlAdv1.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.ThemeStyle.TabStyle.InactiveFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdv1.Controls.Add(this.sfListView1);
            this.tabPageAdv1.Controls.Add(this.metroLabel1);
            this.tabPageAdv1.Controls.Add(this.txtUrl);
            this.tabPageAdv1.Controls.Add(this.metroButton1);
            this.tabPageAdv1.Controls.Add(this.AutoPlaySetting);
            this.tabPageAdv1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(3, 35);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1144, 685);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Downloads";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // sfListView1
            // 
            this.sfListView1.AccessibleName = "ScrollControl";
            this.sfListView1.ItemHeight = 100D;
            this.sfListView1.ItemWidth = 356D;
            this.sfListView1.Location = new System.Drawing.Point(1, 0);
            this.sfListView1.Name = "sfListView1";
            this.sfListView1.Size = new System.Drawing.Size(1141, 592);
            this.sfListView1.TabIndex = 5;
            this.sfListView1.Text = "sfListView1";
            this.sfListView1.DoubleClick += new System.EventHandler(this.SfListView1_DoubleClick);
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSuggestFormula = false;
            this.txtUrl.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.Location = new System.Drawing.Point(41, 627);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(981, 22);
            this.txtUrl.TabIndex = 1;
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
            this.tabPageAdv2.Size = new System.Drawing.Size(1144, 685);
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
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = null;
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(472, 597);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(200, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Video Url:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1027, 627);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Go";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AutoPlaySetting
            // 
            this.AutoPlaySetting.AutoSize = true;
            this.AutoPlaySetting.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.AutoPlaySetting.Location = new System.Drawing.Point(528, 655);
            this.AutoPlaySetting.Name = "AutoPlaySetting";
            this.AutoPlaySetting.Size = new System.Drawing.Size(88, 20);
            this.AutoPlaySetting.TabIndex = 9;
            this.AutoPlaySetting.Text = "Auto Play";
            this.AutoPlaySetting.UseSelectable = true;
            this.AutoPlaySetting.CheckStateChanged += new System.EventHandler(this.AutoPlaySetting_CheckStateChanged);
            // 
            // youtubeVideoInfoBindingSource
            // 
            this.youtubeVideoInfoBindingSource.DataSource = typeof(YoutubeDownloader.Models.YoutubeVideoInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 724);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Youtube Downloader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtUrl;
        private System.Windows.Forms.BindingSource youtubeVideoInfoBindingSource;
        private Syncfusion.WinForms.ListView.SfListView sfListView1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox AutoPlaySetting;
    }
}

