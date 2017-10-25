namespace SPSitesUtils
{
    partial class frm_CreateViews
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.URLSite = new System.Windows.Forms.TextBox();
            this.btn_CreateViews = new System.Windows.Forms.Button();
            this.cb_SubSites = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // URLSite
            // 
            this.URLSite.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLSite.Location = new System.Drawing.Point(52, 31);
            this.URLSite.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.URLSite.Name = "URLSite";
            this.URLSite.Size = new System.Drawing.Size(786, 32);
            this.URLSite.TabIndex = 2;
            this.URLSite.Text = "https://idbg.sharepoint.com/teams/ezShareTestArea/CMS";
            this.URLSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_CreateViews
            // 
            this.btn_CreateViews.Location = new System.Drawing.Point(365, 86);
            this.btn_CreateViews.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_CreateViews.Name = "btn_CreateViews";
            this.btn_CreateViews.Size = new System.Drawing.Size(180, 79);
            this.btn_CreateViews.TabIndex = 3;
            this.btn_CreateViews.Text = "Create Views";
            this.btn_CreateViews.UseVisualStyleBackColor = true;
            this.btn_CreateViews.Click += new System.EventHandler(this.btn_CreateViews_Click);
            // 
            // cb_SubSites
            // 
            this.cb_SubSites.AutoSize = true;
            this.cb_SubSites.Location = new System.Drawing.Point(71, 86);
            this.cb_SubSites.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_SubSites.Name = "cb_SubSites";
            this.cb_SubSites.Size = new System.Drawing.Size(104, 17);
            this.cb_SubSites.TabIndex = 4;
            this.cb_SubSites.Text = "Include Subsites";
            this.cb_SubSites.UseVisualStyleBackColor = true;
            // 
            // frm_CreateViews
            // 
            this.AcceptButton = this.btn_CreateViews;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 203);
            this.Controls.Add(this.cb_SubSites);
            this.Controls.Add(this.btn_CreateViews);
            this.Controls.Add(this.URLSite);
            this.Name = "frm_CreateViews";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLSite;
        private System.Windows.Forms.Button btn_CreateViews;
        private System.Windows.Forms.CheckBox cb_SubSites;
    }
}

