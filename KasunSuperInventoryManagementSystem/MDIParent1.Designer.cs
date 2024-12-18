﻿namespace KasunSuperInventoryManagementSystem
{
    partial class MDIParent1
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            unitToolStripMenuItem = new ToolStripMenuItem();
            addUnitToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addProductNameToolStripMenuItem = new ToolStripMenuItem();
            purchaseProductToolStripMenuItem = new ToolStripMenuItem();
            salesProductToolStripMenuItem = new ToolStripMenuItem();
            dealerToolStripMenuItem = new ToolStripMenuItem();
            dealerInfoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            reportToolStripMenuItem = new ToolStripMenuItem();
            purchaseReportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, unitToolStripMenuItem, productToolStripMenuItem, dealerToolStripMenuItem, reportToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1247, 37);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewUserToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(63, 29);
            userToolStripMenuItem.Text = "User";
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(228, 34);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // unitToolStripMenuItem
            // 
            unitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUnitToolStripMenuItem });
            unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            unitToolStripMenuItem.Size = new Size(60, 29);
            unitToolStripMenuItem.Text = "Unit";
            // 
            // addUnitToolStripMenuItem
            // 
            addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            addUnitToolStripMenuItem.Size = new Size(185, 34);
            addUnitToolStripMenuItem.Text = "Add Unit";
            addUnitToolStripMenuItem.Click += addUnitToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductNameToolStripMenuItem, purchaseProductToolStripMenuItem, salesProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(90, 29);
            productToolStripMenuItem.Text = "Product";
            // 
            // addProductNameToolStripMenuItem
            // 
            addProductNameToolStripMenuItem.Name = "addProductNameToolStripMenuItem";
            addProductNameToolStripMenuItem.Size = new Size(270, 34);
            addProductNameToolStripMenuItem.Text = "Add Product Name";
            addProductNameToolStripMenuItem.Click += addProductNameToolStripMenuItem_Click;
            // 
            // purchaseProductToolStripMenuItem
            // 
            purchaseProductToolStripMenuItem.Name = "purchaseProductToolStripMenuItem";
            purchaseProductToolStripMenuItem.Size = new Size(270, 34);
            purchaseProductToolStripMenuItem.Text = "Purchase Product";
            purchaseProductToolStripMenuItem.Click += purchaseProductToolStripMenuItem_Click;
            // 
            // salesProductToolStripMenuItem
            // 
            salesProductToolStripMenuItem.Name = "salesProductToolStripMenuItem";
            salesProductToolStripMenuItem.Size = new Size(270, 34);
            salesProductToolStripMenuItem.Text = "Sales Product";
            salesProductToolStripMenuItem.Click += salesProductToolStripMenuItem_Click;
            // 
            // dealerToolStripMenuItem
            // 
            dealerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dealerInfoToolStripMenuItem });
            dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            dealerToolStripMenuItem.Size = new Size(78, 29);
            dealerToolStripMenuItem.Text = "Dealer";
            // 
            // dealerInfoToolStripMenuItem
            // 
            dealerInfoToolStripMenuItem.Name = "dealerInfoToolStripMenuItem";
            dealerInfoToolStripMenuItem.Size = new Size(201, 34);
            dealerInfoToolStripMenuItem.Text = "Dealer Info";
            dealerInfoToolStripMenuItem.Click += dealerInfoToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 839);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1247, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(60, 25);
            toolStripStatusLabel.Text = "Status";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { purchaseReportToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(81, 29);
            reportToolStripMenuItem.Text = "Report";
            // 
            // purchaseReportToolStripMenuItem
            // 
            purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            purchaseReportToolStripMenuItem.Size = new Size(270, 34);
            purchaseReportToolStripMenuItem.Text = "Purchase Report";
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1247, 871);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MDIParent1";
            Text = "MDIParent1";
            WindowState = FormWindowState.Maximized;
            Load += MDIParent1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem unitToolStripMenuItem;
        private ToolStripMenuItem addUnitToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addProductNameToolStripMenuItem;
        private ToolStripMenuItem dealerToolStripMenuItem;
        private ToolStripMenuItem dealerInfoToolStripMenuItem;
        private ToolStripMenuItem purchaseProductToolStripMenuItem;
        private ToolStripMenuItem salesProductToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem purchaseReportToolStripMenuItem;
    }
}



