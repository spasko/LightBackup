namespace WebBackup
{
    partial class mainview
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
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.connections = new System.Windows.Forms.ListView();
            this.lp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.next = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 24);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(55, 21);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(131, 24);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(62, 21);
            this.remove.TabIndex = 2;
            this.remove.Text = "Delete";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // connections
            // 
            this.connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lp,
            this.name,
            this.type,
            this.state,
            this.next});
            this.connections.Location = new System.Drawing.Point(12, 51);
            this.connections.Name = "connections";
            this.connections.Size = new System.Drawing.Size(181, 234);
            this.connections.TabIndex = 3;
            this.connections.UseCompatibleStateImageBehavior = false;
            this.connections.SelectedIndexChanged += new System.EventHandler(this.connections_SelectedIndexChanged);
            // 
            // lp
            // 
            this.lp.Text = "Lp.";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // state
            // 
            this.state.Text = "State";
            // 
            // next
            // 
            this.next.Text = "Next";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 291);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(697, 80);
            this.info.TabIndex = 4;
            this.info.Text = "";
            // 
            // mainview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 383);
            this.Controls.Add(this.info);
            this.Controls.Add(this.connections);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Name = "mainview";
            this.Text = "WebBackup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListView connections;
        private System.Windows.Forms.ColumnHeader lp;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader next;
        private System.Windows.Forms.RichTextBox info;
    }
}

