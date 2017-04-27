using KV2Project.MappingObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KV2Project
{
    public partial class Form1 : Form
    {
        private KV2FilterEntities entities = new KV2FilterEntities();
        private List<ChinhDoiObject> listObject = new List<ChinhDoiObject>();
        public Form1()
        {
            InitializeComponent();
            //var firstObject = entities.Chinhs.FirstOrDefault();
            //listObject.Add(MappingObject(firstObject, true));
            //LoadData();
        }

        private void btnAddChinh_Click(object sender, EventArgs e)
        {
            decimal tempDecimal;
            if (!decimal.TryParse(txtTanso.Text, out tempDecimal))
            {
                MessageBox.Show(this, "Tần số phải là giá trị số", "Lỗi!");
                txtTanso.Focus();
                return;
            } else if(!decimal.TryParse(txtHuongdo.Text, out tempDecimal)){
                MessageBox.Show(this, "Hướng dò phải là giá trị số", "Lỗi!");
                txtHuongdo.Focus();
                return;
            } else if(!decimal.TryParse(txtHohieu.Text,out tempDecimal))
            {
                MessageBox.Show(this, "Hô hiệu phải là giá trị số", "Lỗi!");
                txtHohieu.Focus();
                return;
            }
            try
            {
                var txtMinute = txtGio.Text.Substring(txtGio.Text.Length - 2);
                var minute = Convert.ToInt32(txtMinute);
                var hour = Convert.ToInt32(txtGio.Text.Remove(txtGio.Text.Length-2).Trim());
                var date = new DateTime(dpChinhNgay.Value.Year, dpChinhNgay.Value.Month, dpChinhNgay.Value.Day, hour, minute, 0);
                var chinh = new Chinh
                {
                    Tanso = Convert.ToDecimal(txtTanso.Text),
                    Ngay = date,
                    PTLienlac = txtLienlac.Text,
                    Hohieu = txtHohieu.Text,
                    Noidung = txtNoidung.Text,
                    Huongdo = Convert.ToDecimal(txtHuongdo.Text),
                    Mangdai = txtMangdai.Text,
                    Giong = cbGiong.Text,
                    Diaban = txtDiaban.Text,
                    Ghichu = txtGhichu.Text,
                    HohieuDecimal = Convert.ToDecimal(txtHohieu.Text)
                };
                entities.Chinhs.Add(chinh);
                entities.SaveChanges();
                MessageBox.Show(this, "Thêm mới thành công", "Success!!!");
                var tempObject = MappingObject(chinh,true);
                listObject.Add(tempObject);
                LoadData();
                btnAddChinh.Enabled = false;
                btnAddDoi.Enabled = true;
                dpChinhNgay.Enabled = txtGio.Enabled 
                    = txtTanso.Enabled = txtLienlac.Enabled = txtNoidung.Enabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Thêm dữ liệu lỗi!!!", "Error!!!");
            }
        }

        private ChinhDoiObject MappingObject(Chinh chinh,bool isChinh)
        {
            var tempObject = new ChinhDoiObject
            {
                IsChinh = isChinh,
                Diaban = chinh.Diaban,
                Ghichu = chinh.Ghichu,
                Giong = chinh.Giong,
                Hohieu = chinh.Hohieu,
                HohieuDecimal = chinh.HohieuDecimal,
                Huongdo = chinh.Huongdo,
                Mangdai = chinh.Mangdai,
                Ngay = chinh.Ngay,
                Noidung = chinh.Noidung,
                PTLienlac = chinh.PTLienlac,
                Tanso = chinh.Tanso
            };
            return tempObject;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = listObject;
        }

        private void btnAddDoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load data to combobox
            cbGiong.DisplayMember =  "Text";
            cbGiong.ValueMember = "Value";
            var items = new[] {
                new { Text = "Nữ", Value = "0" },
                new { Text = "Nam", Value = "1" },
            };
            cbGiong.DataSource = items;

            btnAddChinh.Enabled = true;
            btnAddDoi.Enabled = btnSave.Enabled = btnDelete.Enabled = false;

            dpChinhNgay.Format =  DateTimePickerFormat.Custom;
            dpChinhNgay.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
