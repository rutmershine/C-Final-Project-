
namespace GUI
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
            this.TV_Show = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.btn_addTag = new System.Windows.Forms.Button();
            this.grp_newTag = new System.Windows.Forms.GroupBox();
            this.txt_tagName = new System.Windows.Forms.TextBox();
            this.lbl_tagName = new System.Windows.Forms.Label();
            this.grp_newTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // TV_Show
            // 
            this.TV_Show.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TV_Show.Location = new System.Drawing.Point(446, 12);
            this.TV_Show.Name = "TV_Show";
            this.TV_Show.Size = new System.Drawing.Size(387, 501);
            this.TV_Show.TabIndex = 1;
            this.TV_Show.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TV_Show_AfterExpand);
            this.TV_Show.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Show_AfterSelect);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(21, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(419, 501);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // btn_addTag
            // 
            this.btn_addTag.Location = new System.Drawing.Point(877, 29);
            this.btn_addTag.Name = "btn_addTag";
            this.btn_addTag.Size = new System.Drawing.Size(153, 105);
            this.btn_addTag.TabIndex = 3;
            this.btn_addTag.Text = "הוסף תגית";
            this.btn_addTag.UseVisualStyleBackColor = true;
            this.btn_addTag.Click += new System.EventHandler(this.btn_addTag_Click);
            // 
            // grp_newTag
            // 
            this.grp_newTag.Controls.Add(this.lbl_tagName);
            this.grp_newTag.Controls.Add(this.txt_tagName);
            this.grp_newTag.Location = new System.Drawing.Point(887, 167);
            this.grp_newTag.Name = "grp_newTag";
            this.grp_newTag.Size = new System.Drawing.Size(172, 193);
            this.grp_newTag.TabIndex = 4;
            this.grp_newTag.TabStop = false;
            // 
            // txt_tagName
            // 
            this.txt_tagName.Location = new System.Drawing.Point(6, 43);
            this.txt_tagName.Name = "txt_tagName";
            this.txt_tagName.Size = new System.Drawing.Size(142, 22);
            this.txt_tagName.TabIndex = 0;
            // 
            // lbl_tagName
            // 
            this.lbl_tagName.AutoSize = true;
            this.lbl_tagName.Location = new System.Drawing.Point(80, 23);
            this.lbl_tagName.Name = "lbl_tagName";
            this.lbl_tagName.Size = new System.Drawing.Size(63, 17);
            this.lbl_tagName.TabIndex = 1;
            this.lbl_tagName.Text = "שם התגית";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 525);
            this.Controls.Add(this.grp_newTag);
            this.Controls.Add(this.btn_addTag);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.TV_Show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_newTag.ResumeLayout(false);
            this.grp_newTag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TV_Show;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btn_addTag;
        private System.Windows.Forms.GroupBox grp_newTag;
        private System.Windows.Forms.Label lbl_tagName;
        private System.Windows.Forms.TextBox txt_tagName;
    }
}

