using WeifenLuo.WinFormsUI.Docking;

namespace XS.ModuleForCore
{
    public partial class Main : Form
    {
        public Main()
        {            
            InitializeComponent();
            this.IsMdiContainer = true; //������������Ϊ�ര������� 

            dockPanel.Theme = vS2015LightTheme1;
            //����������
            dockPanel.DockLeftPortion = 120;
            this.ShowContent("����ģ��", new ModuleList(this), DockState.DockLeft);
            this.ShowContent("��ҳ", new PageIndex());

            //Core2.LogHelper.Write("ϵͳ������");
             


        }

        private void ��ҳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowContent("��ҳ", new PageIndex(), DockState.DockLeft);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowContent("������", new ModuleList(this), DockState.DockLeft);
        }

        #region DockContent ����

        /// <summary>
        /// ��ȡһ��DockContent����
        /// </summary>
        /// <param name="text">��ǩ����</param>
        /// <returns></returns>
        private DockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }
                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }
        /// <summary>
        /// ��ʾһ����ǩ���壬�������ݱ�����Ѱ�ң��Ƿ��Ѿ����ع���ͬ����Ĵ��壬����У���ֱ�Ӽ����
        /// </summary>
        /// <param name="Title">������ʾ���ƣ����</param>
        /// <param name="formType">Ҫ���صı�ǩ���壬���Ҫ�Լ�д�࣬�̳��� DockContent</param>
        /// <param name="dockState">�������ʾ��ʽ��һ��Ϊ���ҵȵ�</param>
        public void ShowContent(string Title, DockContent formType, DockState dockState = DockState.Document)
        {

            DockContent frm = FindDocument(Title);
            if (frm == null)
            {
                formType.DockHandler.TabText = Title;
                formType.Show(this.dockPanel, dockState);
            }
            else
            {
                frm.Show(this.dockPanel, dockState);
                frm.BringToFront();
            }
        }
        #endregion
    }
}