namespace HelloServiceWindowsServiceHost
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloWindowsServiceProcess = new System.ServiceProcess.ServiceProcessInstaller();
            this.HelloWindowsService = new System.ServiceProcess.ServiceInstaller();
            // 
            // HelloWindowsServiceProcess
            // 
            this.HelloWindowsServiceProcess.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.HelloWindowsServiceProcess.Password = null;
            this.HelloWindowsServiceProcess.Username = null;
            // 
            // HelloWindowsService
            // 
            this.HelloWindowsService.ServiceName = "HelloWindowsService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.HelloWindowsServiceProcess,
            this.HelloWindowsService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller HelloWindowsServiceProcess;
        private System.ServiceProcess.ServiceInstaller HelloWindowsService;
    }
}