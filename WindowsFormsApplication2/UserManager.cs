using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using Sonartez.Hepldesk.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class UserManager : Form
    {
        IEnumerable<TblUser> lstUser;
        Boolean createNewFlag;
        Boolean editFlag;
        TblUser currentUser;
        BBLUser user = new BBLUser();
        public UserManager()
        {
            InitializeComponent();
        }

        private void LoadUser()
        {

            lstUser = user.GetUser();
            gridControl1.DataSource = lstUser;
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            currentUser = null;
            panel1.Height = 40;
            LoadUser();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createNewFlag = true;
            panel1.Height = 200;
            panelEdit.Visible = true;
            clearForm();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            txtUserName.Focus();
        }

        private void clearForm()
        {
            txtEmail.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtUserName.Text = string.Empty;

            txtPass.Enabled = true;
            txtUserName.Enabled = true;

            chkActive.Checked = true;
            radioTraCuu.Checked = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvMainInfo.SelectedRowsCount > 0)
            {
                var obj = (TblUser)lstUser.ToList()[grvMainInfo.GetFocusedDataSourceRowIndex()];

                //var obj = (TblInfor)lstShowData.ToList()[grvMainInfo.GetDataSourceRowIndex(e.FocusedRowHandle)];
                if (obj != null)
                {
                    editFlag = true;
                    panel1.Height = 200;
                    panelEdit.Visible = true;

                    btnCreate.Enabled = false;
                    btnDelete.Enabled = false;

                    gridControl1.Enabled = false;

                    currentUser = user.GetUserByID(obj.UserID);
                    txtEmail.Text = currentUser.Email;
                    txtFullName.Text = currentUser.FullName;
                    txtPass.Enabled = false;
                    txtPass.Text = currentUser.Password;
                    txtPhone.Text = currentUser.PhoneNumber;
                    txtUserName.Text = currentUser.UserName;
                    txtUserName.Enabled = false;

                    chkActive.Checked = (currentUser.Active.Value == 1);

                    if (currentUser.Permission == Permission.Normal)
                        radioTraCuu.Checked = true;
                    if (currentUser.Permission == Permission.Approval)
                        radioKiemDuyet.Checked = true;
                    if (currentUser.Permission == Permission.Admin)
                        radioQuanLy.Checked = true;
                }
                else
                {
                    clearForm();
                    editFlag = false;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validFormData())
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),"Dữ liệu không đủ hoặc chính xác, hãy kiểm tra lại", "Không thể thêm mới " + txtFullName.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (createNewFlag)
            {
                currentUser = new TblUser();
                currentUser.UserID = Guid.NewGuid();
                currentUser.Active = chkActive.Checked ? 1 : 0;

                currentUser.Email = txtEmail.Text;
                currentUser.FullName = txtFullName.Text;
                currentUser.Password = txtPass.Text;
                currentUser.PhoneNumber = txtPhone.Text;
                currentUser.UserName = txtUserName.Text;

                if (radioKiemDuyet.Checked)
                    currentUser.Permission = Permission.Approval;
                if (radioQuanLy.Checked)
                    currentUser.Permission = Permission.Admin;

                if (radioTraCuu.Checked)
                    currentUser.Permission = Permission.Normal;

                
                bool complete = false;
                try
                {
                    user.SaveUser(currentUser);
                    complete = true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), ex.Message, "Không thể thêm mới " + txtFullName.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (complete)
                {
                    //MessageBox.Show("Thêm mới thành công");
                    DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), "Thêm mới thành công  " + txtFullName.Text, "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetInCancel();

                    LoadUser();
                }

            }
                if (editFlag)
                {
                    currentUser.Active = chkActive.Checked ? 1 : 0;
                    if (radioKiemDuyet.Checked)
                        currentUser.Permission = Permission.Approval;
                    if (radioQuanLy.Checked)
                        currentUser.Permission = Permission.Admin;

                    if (radioTraCuu.Checked)
                        currentUser.Permission = Permission.Normal;
                    currentUser.Email = txtEmail.Text;
                    currentUser.FullName = txtFullName.Text;
                    currentUser.PhoneNumber = txtPhone.Text;

                    bool complete = false;
                    try
                    {
                        user.UpdateUser(currentUser);
                        complete = true;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), ex.Message, "Không thể cập nhập " + txtFullName.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    if (complete)
                    {
                        
                        DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), "Thành công ", "Cập nhập thành công  " + txtFullName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetInCancel();
                         
                        LoadUser();
                    }


                }
            
        }


        private bool validFormData()
        {
            bool flag = true;

            if (txtUserName.Text.Trim().Length == 0 || txtUserName.Text.Trim().Contains(' ')) {
                flag = false;
            }

            if (txtPass.Text.Trim().Length == 0)
                flag = false;

            return flag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInCancel();
        }

        private void ResetInCancel()
        {
            clearForm();
            panel1.Height = 40;
            panelEdit.Visible = false;
            editFlag = false;
            createNewFlag = false;
            gridControl1.Enabled = true;
            btnCreate.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            if (grvMainInfo.SelectedRowsCount > 0)
            {
                var obj = (TblUser)lstUser.ToList()[grvMainInfo.GetFocusedDataSourceRowIndex()];
                if (obj != null)
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), "Bạn chắc chắn muốn xóa  " + obj.FullName,"Xóa thông tin",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {
                            //user.Delete(obj);

                            obj.IsDeleted = 1;
                            user.UpdateUser(obj);

                            DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), "Thành công", "Đã xóa " + obj.FullName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadUser();
                        }
                        catch (Exception ex)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), ex.Message, "Không thể xóa " + obj.FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadUser();
                        }
                    }
                }
            }
        }


    }
}
