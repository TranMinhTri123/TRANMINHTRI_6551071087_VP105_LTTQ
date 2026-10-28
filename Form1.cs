using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BaIKiemTraGiuaKyLTTQ
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=.;Initial Catalog=DuLieu_ThietBi;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDuLieu()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaThietBi, TenThietBi, DonGia FROM ThietBi", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvThietBi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XoaTrang()
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtDonGia.Clear();
            txtMaTB.Focus();
        }

        private void lblDonGia_Click(object sender, EventArgs e)
        {
        }

        // Câu 1: Khi form mới được Load lên
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;

            LoadDuLieu();
        }

        // Câu 2: Chỉ cho phép nhập số thực hoặc số nguyên vào TextBox Đơn giá
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (char.IsDigit(e.KeyChar)) return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtDonGia.Text.Contains('.') && !txtDonGia.Text.Contains(','))
            {
                return;
            }

            e.Handled = true;
        }

        // Câu 3: Khi người dùng chọn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Câu 4: Khi người dùng chọn nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaTB.Text.Trim();
            string ten = txtTenTB.Text.Trim();
            string gia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmdKT = new SqlCommand("SELECT COUNT(*) FROM ThietBi WHERE MaThietBi = @ma", con);
                    cmdKT.Parameters.AddWithValue("@ma", ma);
                    int count = (int)cmdKT.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã thiết bị đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaTB.Focus();
                        txtMaTB.SelectAll();
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO ThietBi (MaThietBi, TenThietBi, DonGia) VALUES (@ma, @ten, @gia)", con);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.ExecuteNonQuery();
                }

                LoadDuLieu();
                XoaTrang();
                btnThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Câu 5: Khi người dùng chọn một thiết bị ở dưới lưới Danh sách thiết bị
        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThietBi.Rows.Count)
            {
                DataGridViewRow r = dgvThietBi.Rows[e.RowIndex];
                txtMaTB.Text = r.Cells[0].Value?.ToString();
                txtTenTB.Text = r.Cells[1].Value?.ToString();
                txtDonGia.Text = r.Cells[2].Value?.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Câu 6: Khi người dùng chọn nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaTB.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Bạn có muốn xóa thiết bị này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ThietBi WHERE MaThietBi = @ma", con);
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.ExecuteNonQuery();
                    }

                    LoadDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            XoaTrang();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        // Câu 7: Khi người dùng chọn nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaTB.Text.Trim();
            string ten = txtTenTB.Text.Trim();
            string gia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ThietBi SET TenThietBi = @ten, DonGia = @gia WHERE MaThietBi = @ma", con);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.ExecuteNonQuery();
                }

                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            XoaTrang();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void txtTenTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
