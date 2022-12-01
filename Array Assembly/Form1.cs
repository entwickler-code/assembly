using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Array
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtTexto;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.ListBox ListArray;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.btn = new System.Windows.Forms.Button();
			this.ListArray = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtTexto
			// 
			this.txtTexto.Location = new System.Drawing.Point(8, 32);
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(400, 20);
			this.txtTexto.TabIndex = 0;
			this.txtTexto.Text = "textBox1";
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(120, 56);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(144, 23);
			this.btn.TabIndex = 1;
			this.btn.Text = "button1";
			this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// ListArray
			// 
			this.ListArray.Location = new System.Drawing.Point(8, 88);
			this.ListArray.Name = "ListArray";
			this.ListArray.Size = new System.Drawing.Size(400, 316);
			this.ListArray.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 437);
			this.Controls.Add(this.ListArray);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.txtTexto);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btn_Click(object sender, System.EventArgs e)
		{
			char[ ] aMyArray;
			int Count;

			aMyArray = txtTexto.Text.ToCharArray(0,txtTexto.Text.Length);
			ListArray.Items.Add("Tamanho de aMyArray = " + aMyArray.Length.ToString());

			for (Count=0;Count!=aMyArray.Length;Count = Count + 1)
				ListArray.Items.Add("Indice[" + (Count.ToString()) + "]= " +  aMyArray[Count] + "  teste");
			
		}
	}
}
