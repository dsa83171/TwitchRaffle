namespace Raffle
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.RuffleBtn = new System.Windows.Forms.Button();
            this.DelBtn2 = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ViewCont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labBingo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel Name";
            // 
            // ChannelName
            // 
            this.ChannelName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChannelName.ForeColor = System.Drawing.Color.DarkGray;
            this.ChannelName.Location = new System.Drawing.Point(162, 12);
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Size = new System.Drawing.Size(200, 29);
            this.ChannelName.TabIndex = 90;
            this.ChannelName.Text = "輸入後按Enter";
            this.ChannelName.Enter += new System.EventHandler(this.ChannelName_Enter);
            this.ChannelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChannelName_KeyDown);
            this.ChannelName.Leave += new System.EventHandler(this.ChannelName_Leave);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(350, 344);
            this.listBox1.TabIndex = 3;
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelBtn.Location = new System.Drawing.Point(121, 402);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(103, 42);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "刪除名單";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddItemBtn.Location = new System.Drawing.Point(11, 402);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(103, 42);
            this.AddItemBtn.TabIndex = 5;
            this.AddItemBtn.Text = "新增名單";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(394, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(383, 344);
            this.listBox2.TabIndex = 6;
            // 
            // RuffleBtn
            // 
            this.RuffleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RuffleBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RuffleBtn.Location = new System.Drawing.Point(501, 402);
            this.RuffleBtn.Name = "RuffleBtn";
            this.RuffleBtn.Size = new System.Drawing.Size(135, 42);
            this.RuffleBtn.TabIndex = 7;
            this.RuffleBtn.Text = "抽獎";
            this.RuffleBtn.UseVisualStyleBackColor = true;
            this.RuffleBtn.Click += new System.EventHandler(this.RuffleBtn_Click);
            // 
            // DelBtn2
            // 
            this.DelBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DelBtn2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelBtn2.Location = new System.Drawing.Point(642, 402);
            this.DelBtn2.Name = "DelBtn2";
            this.DelBtn2.Size = new System.Drawing.Size(135, 42);
            this.DelBtn2.TabIndex = 8;
            this.DelBtn2.Text = "流放中獎者";
            this.DelBtn2.UseVisualStyleBackColor = true;
            this.DelBtn2.Click += new System.EventHandler(this.DelBtn2_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FilterBtn.Location = new System.Drawing.Point(231, 402);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(132, 42);
            this.FilterBtn.TabIndex = 9;
            this.FilterBtn.Text = "過濾機器人";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ViewCont
            // 
            this.ViewCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCont.AutoSize = true;
            this.ViewCont.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ViewCont.Location = new System.Drawing.Point(694, 27);
            this.ViewCont.Name = "ViewCont";
            this.ViewCont.Size = new System.Drawing.Size(14, 16);
            this.ViewCont.TabIndex = 10;
            this.ViewCont.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(639, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "總人數: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(639, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "中獎數: ";
            // 
            // labBingo
            // 
            this.labBingo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labBingo.AutoSize = true;
            this.labBingo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBingo.Location = new System.Drawing.Point(694, 9);
            this.labBingo.Name = "labBingo";
            this.labBingo.Size = new System.Drawing.Size(14, 16);
            this.labBingo.TabIndex = 12;
            this.labBingo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labBingo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewCont);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.DelBtn2);
            this.Controls.Add(this.RuffleBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ChannelName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Twitch Raffle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChannelName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button RuffleBtn;
        private System.Windows.Forms.Button DelBtn2;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ViewCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labBingo;
    }
}

