namespace Web_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnCadTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdTeahcer = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdStudent = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStudent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonTeacher = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.list = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.btnCadTeacher,
            this.btnRemTeacher,
            this.btnUpdTeahcer,
            this.btnAddStudent,
            this.btnRemStudent,
            this.btnUpdStudent});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonStudent,
            this.ribbonTeacher});
            this.ribbonControl1.Size = new System.Drawing.Size(905, 143);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnCadTeacher
            // 
            this.btnCadTeacher.Id = 2;
            this.btnCadTeacher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadTeacher.ImageOptions.Image")));
            this.btnCadTeacher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCadTeacher.ImageOptions.LargeImage")));
            this.btnCadTeacher.Name = "btnCadTeacher";
            this.btnCadTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCadTeacher_ItemClick);
            // 
            // btnRemTeacher
            // 
            this.btnRemTeacher.Id = 3;
            this.btnRemTeacher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemTeacher.ImageOptions.Image")));
            this.btnRemTeacher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemTeacher.ImageOptions.LargeImage")));
            this.btnRemTeacher.Name = "btnRemTeacher";
            // 
            // btnUpdTeahcer
            // 
            this.btnUpdTeahcer.Id = 4;
            this.btnUpdTeahcer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdTeahcer.ImageOptions.Image")));
            this.btnUpdTeahcer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdTeahcer.ImageOptions.LargeImage")));
            this.btnUpdTeahcer.Name = "btnUpdTeahcer";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Id = 5;
            this.btnAddStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.ImageOptions.Image")));
            this.btnAddStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.ImageOptions.LargeImage")));
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddStudent_ItemClick);
            // 
            // btnRemStudent
            // 
            this.btnRemStudent.Id = 6;
            this.btnRemStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemStudent.ImageOptions.Image")));
            this.btnRemStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemStudent.ImageOptions.LargeImage")));
            this.btnRemStudent.Name = "btnRemStudent";
            // 
            // btnUpdStudent
            // 
            this.btnUpdStudent.Id = 7;
            this.btnUpdStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdStudent.ImageOptions.Image")));
            this.btnUpdStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdStudent.ImageOptions.LargeImage")));
            this.btnUpdStudent.Name = "btnUpdStudent";
            // 
            // ribbonStudent
            // 
            this.ribbonStudent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSkins});
            this.ribbonStudent.Name = "ribbonStudent";
            this.ribbonStudent.Text = "Student";
            // 
            // rpgSkins
            // 
            this.rpgSkins.ItemLinks.Add(this.btnAddStudent);
            this.rpgSkins.ItemLinks.Add(this.btnRemStudent);
            this.rpgSkins.ItemLinks.Add(this.btnUpdStudent);
            this.rpgSkins.Name = "rpgSkins";
            this.rpgSkins.Text = "Skins";
            // 
            // ribbonTeacher
            // 
            this.ribbonTeacher.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonTeacher.Name = "ribbonTeacher";
            this.ribbonTeacher.Text = "Teacher";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCadTeacher);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRemTeacher);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdTeahcer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(0, 139);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(905, 355);
            this.list.TabIndex = 2;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 491);
            this.Controls.Add(this.list);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkins;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonTeacher;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCadTeacher;
        private DevExpress.XtraBars.BarButtonItem btnRemTeacher;
        private DevExpress.XtraBars.BarButtonItem btnUpdTeahcer;
        private DevExpress.XtraBars.BarButtonItem btnAddStudent;
        private DevExpress.XtraBars.BarButtonItem btnRemStudent;
        private DevExpress.XtraBars.BarButtonItem btnUpdStudent;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.ListBox list;
    }
}
