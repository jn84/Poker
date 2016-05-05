namespace Poker
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
			this.pictCard_1 = new System.Windows.Forms.PictureBox();
			this.btnDraw = new System.Windows.Forms.Button();
			this.pictCard_2 = new System.Windows.Forms.PictureBox();
			this.pictCard_3 = new System.Windows.Forms.PictureBox();
			this.pictCard_4 = new System.Windows.Forms.PictureBox();
			this.pictCard_5 = new System.Windows.Forms.PictureBox();
			this.btnSort = new System.Windows.Forms.Button();
			this.txtWinType = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_5)).BeginInit();
			this.SuspendLayout();
			// 
			// pictCard_1
			// 
			this.pictCard_1.Location = new System.Drawing.Point(12, 12);
			this.pictCard_1.Name = "pictCard_1";
			this.pictCard_1.Size = new System.Drawing.Size(167, 244);
			this.pictCard_1.TabIndex = 0;
			this.pictCard_1.TabStop = false;
			// 
			// btnDraw
			// 
			this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDraw.Location = new System.Drawing.Point(12, 341);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(369, 70);
			this.btnDraw.TabIndex = 1;
			this.btnDraw.Text = "Draw New Cards";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.newHand_Click);
			// 
			// pictCard_2
			// 
			this.pictCard_2.Location = new System.Drawing.Point(185, 12);
			this.pictCard_2.Name = "pictCard_2";
			this.pictCard_2.Size = new System.Drawing.Size(167, 244);
			this.pictCard_2.TabIndex = 5;
			this.pictCard_2.TabStop = false;
			// 
			// pictCard_3
			// 
			this.pictCard_3.Location = new System.Drawing.Point(358, 12);
			this.pictCard_3.Name = "pictCard_3";
			this.pictCard_3.Size = new System.Drawing.Size(167, 244);
			this.pictCard_3.TabIndex = 6;
			this.pictCard_3.TabStop = false;
			// 
			// pictCard_4
			// 
			this.pictCard_4.Location = new System.Drawing.Point(531, 12);
			this.pictCard_4.Name = "pictCard_4";
			this.pictCard_4.Size = new System.Drawing.Size(167, 244);
			this.pictCard_4.TabIndex = 7;
			this.pictCard_4.TabStop = false;
			// 
			// pictCard_5
			// 
			this.pictCard_5.Location = new System.Drawing.Point(704, 12);
			this.pictCard_5.Name = "pictCard_5";
			this.pictCard_5.Size = new System.Drawing.Size(167, 244);
			this.pictCard_5.TabIndex = 8;
			this.pictCard_5.TabStop = false;
			// 
			// btnSort
			// 
			this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSort.Location = new System.Drawing.Point(502, 341);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(369, 70);
			this.btnSort.TabIndex = 9;
			this.btnSort.Text = "Sort Cards";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// txtWinType
			// 
			this.txtWinType.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtWinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWinType.Location = new System.Drawing.Point(12, 268);
			this.txtWinType.Name = "txtWinType";
			this.txtWinType.ReadOnly = true;
			this.txtWinType.Size = new System.Drawing.Size(859, 62);
			this.txtWinType.TabIndex = 10;
			this.txtWinType.Text = "None";
			this.txtWinType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 424);
			this.Controls.Add(this.txtWinType);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.pictCard_5);
			this.Controls.Add(this.pictCard_4);
			this.Controls.Add(this.pictCard_3);
			this.Controls.Add(this.pictCard_2);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.pictCard_1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictCard_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictCard_5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictCard_1;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.PictureBox pictCard_2;
		private System.Windows.Forms.PictureBox pictCard_3;
		private System.Windows.Forms.PictureBox pictCard_4;
		private System.Windows.Forms.PictureBox pictCard_5;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.TextBox txtWinType;
	}
}

