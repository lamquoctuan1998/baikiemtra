using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void LoadSQL()
        {
            using(QLSVEntities qlEntity = new QLSVEntities())
            {
                var kq = from xyz in qlEntity.qlsv select xyz;
                lv_DanhSach.Items.Clear();
                lv_DanhSach.Groups.Clear();

                ListViewGroup lv_van = new ListViewGroup("Khoa Văn");
                lv_DanhSach.Groups.Add(lv_van);
                ListViewGroup lv_vatly = new ListViewGroup("Khoa Vật lý");
                lv_DanhSach.Groups.Add(lv_vatly);
                ListViewGroup lv_cntt = new ListViewGroup("Khoa CNTT");
                lv_DanhSach.Groups.Add(lv_cntt);

                foreach(var data in kq)
                {
                    DateTime bd = (DateTime)data.NgaySinh;
                    ListViewItem lv_item = new ListViewItem(data.MaSV);     //0
                    lv_item.SubItems.Add(data.TenSV);                       //1
                    lv_item.SubItems.Add(data.Khoa);                        //2
                    lv_item.SubItems.Add(data.GioiTinh);                    //3
                    lv_item.SubItems.Add(bd.ToString("dd'/'MM'/'yyyy"));    //4                      
                    lv_item.SubItems.Add(data.Diem1.ToString());            //5
                    lv_item.SubItems.Add(data.Diem2.ToString());            //6
                    lv_item.SubItems.Add(data.Diem3.ToString());            //7
                    lv_item.SubItems.Add(data.Diem4.ToString());            //8

                    float dtb = -1;
                    if (String.Compare(data.Khoa, "Van", true) == 0)
                        dtb = (float)(data.Diem1 + data.Diem2) / 2;
                    if (String.Compare(data.Khoa, "Vatly", true) == 0)
                        dtb = (float)(data.Diem1 + data.Diem2 + data.Diem3 + data.Diem4) / 4;
                    if (String.Compare(data.Khoa, "CNTT", true) == 0)
                        dtb = (float)(data.Diem1 + data.Diem2 + data.Diem3) / 3;

                    lv_item.SubItems.Add(dtb.ToString());                   //9
                    lv_DanhSach.Items.Add(lv_item);
                    if (String.Compare(data.Khoa, "Van", true) == 0) lv_item.Group = lv_van;
                    if (String.Compare(data.Khoa, "VatLy", true) == 0) lv_item.Group = lv_vatly;
                    if (String.Compare(data.Khoa, "CNTT", true) == 0) lv_item.Group = lv_cntt;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSQL();
        }

        private void lv_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem list in lv_DanhSach.SelectedItems)
            {
                txtHoTen.Text = list.SubItems[1].Text;
                if (list.SubItems[3].Text == "Nam") checkBoxNam.Checked = true;
                    else checkBoxNam.Checked = false;
                txtNgaySinh.Text = list.SubItems[4].Text;
                if(list.SubItems[2].Text == "Van")
                {
                    txtVHCD.Text = list.SubItems[5].Text;
                    txtVHHD.Text = list.SubItems[6].Text;
                    txtCoHoc.Text = "";
                    txtQuangHoc.Text = "";
                    txtDien.Text = "";
                    txtVLHN.Text = "";
                    txtPascal.Text = "";
                    txtCSharp.Text = "";
                    txtSQL.Text = "";
                    tcDiem.SelectedTab = tpVan;
                }

                if (list.SubItems[2].Text == "VatLy")
                {
                    txtVHCD.Text = "";
                    txtVHHD.Text = "";
                    txtCoHoc.Text = list.SubItems[5].Text;
                    txtQuangHoc.Text = list.SubItems[6].Text;
                    txtDien.Text = list.SubItems[7].Text;
                    txtVLHN.Text = list.SubItems[8].Text;
                    txtPascal.Text = "";
                    txtCSharp.Text = "";
                    txtSQL.Text = "";
                    tcDiem.SelectedTab = tpVatLy;
                }

                if (list.SubItems[2].Text == "CNTT")
                {
                    txtVHCD.Text = "";
                    txtVHHD.Text = "";
                    txtCoHoc.Text = "";
                    txtQuangHoc.Text = "";
                    txtDien.Text = "";
                    txtVLHN.Text = "";
                    txtPascal.Text = list.SubItems[5].Text;
                    txtCSharp.Text = list.SubItems[6].Text;
                    txtSQL.Text = list.SubItems[7].Text;
                    tcDiem.SelectedTab = tpCNTT;
                }

                txtDTB.Text = list.SubItems[9].Text;
            }
        }

        void LamMoi()
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            checkBoxNam.Checked = false;
            txtDTB.Text = "";
            txtVHCD.Text = "";
            txtVHHD.Text = "";
            txtCoHoc.Text = "";
            txtQuangHoc.Text = "";
            txtDien.Text = "";
            txtVLHN.Text = "";
            txtPascal.Text = "";
            txtCSharp.Text = "";
            txtSQL.Text = "";
        }
        String tab = "";
        private void svVan_Click(object sender, EventArgs e)
        {
            tcDiem.SelectedTab = tpVan;
            LamMoi();
            tab = "Van";
        }
        
        private void svVatLy_Click(object sender, EventArgs e)
        {
            tcDiem.SelectedTab = tpVatLy;
            LamMoi();
            tab = "VatLy";
        }

        private void SvCNTT_Click(object sender, EventArgs e)
        {
            tcDiem.SelectedTab = tpCNTT;
            LamMoi();
            tab = "CNTT";
        }

        private void mnLuu_Click(object sender, EventArgs e)
        {
            using (QLSVEntities qlE = new QLSVEntities())
            {
                qlsv sv = new qlsv();
                sv.MaSV = Base.getMa();
                sv.TenSV = txtHoTen.Text;
                if (checkBoxNam.Checked == true) sv.GioiTinh = "Nam";
                else sv.GioiTinh = "Nữ";
                DateTime bd = Convert.ToDateTime(txtNgaySinh.Text);
                sv.NgaySinh = bd;
                sv.Khoa = tab;
                switch (tab)
                {
                    case "Van":
                        {
                            sv.Diem1 = float.Parse(txtVHCD.Text);
                            sv.Diem2 = float.Parse(txtVHHD.Text);
                            break;
                        }
                    case "VatLy":
                        {
                            sv.Diem1 = float.Parse(txtCoHoc.Text);
                            sv.Diem2 = float.Parse(txtQuangHoc.Text);
                            sv.Diem3 = float.Parse(txtDien.Text);
                            sv.Diem4 = float.Parse(txtVLHN.Text);
                            break;
                        }
                    default:
                        {
                            sv.Diem1 = float.Parse(txtPascal.Text);
                            sv.Diem2 = float.Parse(txtCSharp.Text);
                            sv.Diem3 = float.Parse(txtSQL.Text);
                            break;
                        }
                }
                qlE.qlsv.Add(sv);
                qlE.SaveChanges();
                LoadSQL();
            }
        }
        String key = "";
        private void mnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem list in lv_DanhSach.SelectedItems)
            {
                key = list.SubItems[0].Text;
                break;
            }

            using (QLSVEntities qlE = new QLSVEntities())
            {
                if (key == "") return;
                qlsv sv = qlE.qlsv.Where(p => p.MaSV == key).SingleOrDefault();
                qlE.qlsv.Remove(sv);
                qlE.SaveChanges();
                LoadSQL();
                key = "";
            }
        }

        private void mnSua_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem list in lv_DanhSach.SelectedItems)
            {
                key = list.SubItems[0].Text;
                break;
            }

            using (QLSVEntities qlE = new QLSVEntities())
            {
                if (key == "") return;
                qlsv sv = qlE.qlsv.Where(p => p.MaSV == key).SingleOrDefault();
                sv.TenSV = txtHoTen.Text;
                DateTime bd = Convert.ToDateTime(txtNgaySinh.Text);
                sv.NgaySinh = bd;
                switch (sv.Khoa)
                {
                    case "Van":
                        {
                            sv.Diem1 = float.Parse(txtVHCD.Text);
                            sv.Diem2 = float.Parse(txtVHHD.Text);
                            break;
                        }
                    case "VatLy":
                        {
                            sv.Diem1 = float.Parse(txtCoHoc.Text);
                            sv.Diem2 = float.Parse(txtQuangHoc.Text);
                            sv.Diem3 = float.Parse(txtDien.Text);
                            sv.Diem4 = float.Parse(txtVLHN.Text);
                            break;
                        }
                    default:
                        {
                            sv.Diem1 = float.Parse(txtPascal.Text);
                            sv.Diem2 = float.Parse(txtCSharp.Text);
                            sv.Diem3 = float.Parse(txtSQL.Text);
                            break;
                        }
                }
                qlE.SaveChanges();
                LoadSQL();
                key = "";
            }
        }
    }
}
